using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

public class GlobalRateLimitMiddleware
{
    private readonly IConfiguration configuration;
    private readonly RequestDelegate _next;
    private readonly ILogger<GlobalRateLimitMiddleware> _logger;

    // Thread-safe dictionary to store request timestamps per IP
    private static readonly ConcurrentDictionary<string, Queue<DateTime>> _requestHistory = new ConcurrentDictionary<string, Queue<DateTime>>();
    
    // Configuration
    private static int MaxRequestsPerMinute;
    private static readonly TimeSpan WindowDuration = TimeSpan.FromMinutes(1);
    
    // Clean up old entries periodically (optional optimization)
    private static DateTime _lastCleanup = DateTime.UtcNow;
    private static readonly TimeSpan CleanupInterval = TimeSpan.FromMinutes(5);

    public GlobalRateLimitMiddleware(RequestDelegate next, ILogger<GlobalRateLimitMiddleware> logger, IConfiguration _configuration)
    {
        _next = next;
        _logger = logger;
        configuration = _configuration;
        MaxRequestsPerMinute = Convert.ToInt32(_configuration["MaxRequestsPerMinute"]);
    }

    public async Task InvokeAsync(HttpContext context)
    {
        // Get client IP address
        var clientIP = NetworkTools.GetClientIPAddress(context).ToString();
        
        // Skip rate limiting for certain endpoints if needed (optional)
        if (ShouldSkipRateLimit(context.Request.Path))
        {
            await _next(context);
            return;
        }

        // Check rate limit
        if (!IsWithinRateLimit(clientIP))
        {
            // Rate limit exceeded
            var currentCount = GetCurrentRequestCount(clientIP);
            var timeUntilReset = GetTimeUntilReset(clientIP);
            
            _logger.LogWarning("Rate limit exceeded for IP {ClientIP}. Current requests: {CurrentCount}, Time until reset: {TimeUntilReset}", 
                clientIP, currentCount, timeUntilReset);

            context.Response.StatusCode = 429; // Too Many Requests
            context.Response.Headers.Add("Retry-After", ((int)timeUntilReset.TotalSeconds).ToString());
            context.Response.Headers.Add("X-RateLimit-Limit", MaxRequestsPerMinute.ToString());
            context.Response.Headers.Add("X-RateLimit-Remaining", "0");
            context.Response.Headers.Add("X-RateLimit-Reset", DateTimeOffset.UtcNow.Add(timeUntilReset).ToUnixTimeSeconds().ToString());

            await context.Response.WriteAsync(System.Text.Json.JsonSerializer.Serialize(new
            {
                error = "Rate limit exceeded",
                message = $"Too many requests. Maximum {MaxRequestsPerMinute} requests per minute allowed.",
                retryAfter = (int)timeUntilReset.TotalSeconds
            }));
            return;
        }

        // Add rate limit headers for successful requests
        var remainingRequests = MaxRequestsPerMinute - GetCurrentRequestCount(clientIP);
        var resetTime = GetTimeUntilReset(clientIP);
        
        context.Response.Headers.Add("X-RateLimit-Limit", MaxRequestsPerMinute.ToString());
        context.Response.Headers.Add("X-RateLimit-Remaining", Math.Max(0, remainingRequests - 1).ToString()); // -1 because we're about to process this request
        context.Response.Headers.Add("X-RateLimit-Reset", DateTimeOffset.UtcNow.Add(resetTime).ToUnixTimeSeconds().ToString());

        // Continue to the next middleware
        await _next(context);
    }

    /// Checks if the given IP address is within the rate limit
    private static bool IsWithinRateLimit(string ipAddress)
    {
        if (string.IsNullOrEmpty(ipAddress))
            return false;

        var now = DateTime.UtcNow;
        var cutoffTime = now - WindowDuration;

        // Get or create the request queue for this IP
        var requestQueue = _requestHistory.GetOrAdd(ipAddress, _ => new Queue<DateTime>());

        lock (requestQueue)
        {
            // Remove requests older than our window
            while (requestQueue.Count > 0 && requestQueue.Peek() <= cutoffTime)
            {
                requestQueue.Dequeue();
            }

            // Check if adding this request would exceed the limit
            if (requestQueue.Count >= MaxRequestsPerMinute)
            {
                return false;
            }

            // Add the current request
            requestQueue.Enqueue(now);
        }

        // Perform periodic cleanup
        PerformCleanupIfNeeded();

        return true;
    }

    /// Gets the number of requests made by an IP in the current window
    private static int GetCurrentRequestCount(string ipAddress)
    {
        if (string.IsNullOrEmpty(ipAddress))
            return 0;

        if (!_requestHistory.TryGetValue(ipAddress, out var requestQueue))
            return 0;

        var cutoffTime = DateTime.UtcNow - WindowDuration;

        lock (requestQueue)
        {
            // Remove old requests first
            while (requestQueue.Count > 0 && requestQueue.Peek() <= cutoffTime)
            {
                requestQueue.Dequeue();
            }

            return requestQueue.Count;
        }
    }

    /// Gets the estimated time until the rate limit resets for an IP
    private static TimeSpan GetTimeUntilReset(string ipAddress)
    {
        var oldestRequest = GetOldestRequestTime(ipAddress);
        if (!oldestRequest.HasValue)
            return TimeSpan.Zero;

        var resetTime = oldestRequest.Value + WindowDuration;
        var timeUntilReset = resetTime - DateTime.UtcNow;
        
        return timeUntilReset > TimeSpan.Zero ? timeUntilReset : TimeSpan.Zero;
    }

    /// Gets the time when the oldest request in the window was made
    private static DateTime? GetOldestRequestTime(string ipAddress)
    {
        if (string.IsNullOrEmpty(ipAddress))
            return null;

        if (!_requestHistory.TryGetValue(ipAddress, out var requestQueue))
            return null;

        var cutoffTime = DateTime.UtcNow - WindowDuration;

        lock (requestQueue)
        {
            // Remove old requests first
            while (requestQueue.Count > 0 && requestQueue.Peek() <= cutoffTime)
            {
                requestQueue.Dequeue();
            }

            return requestQueue.Count > 0 ? requestQueue.Peek() : (DateTime?)null;
        }
    }

    /// Clears all rate limit data for a specific IP (useful for whitelisting)
    public static void ClearRateLimitData(string ipAddress)
    {
        if (string.IsNullOrEmpty(ipAddress))
            return;

        _requestHistory.TryRemove(ipAddress, out _);
    }

    /// Gets statistics about current rate limiting
    public static Dictionary<string, int> GetCurrentStatistics()
    {
        var stats = new Dictionary<string, int>();
        var cutoffTime = DateTime.UtcNow - WindowDuration;

        foreach (var kvp in _requestHistory)
        {
            var requestQueue = kvp.Value;
            lock (requestQueue)
            {
                // Remove old requests
                while (requestQueue.Count > 0 && requestQueue.Peek() <= cutoffTime)
                {
                    requestQueue.Dequeue();
                }

                if (requestQueue.Count > 0)
                {
                    stats[kvp.Key] = requestQueue.Count;
                }
            }
        }

        return stats;
    }

    /// Performs cleanup of old IP entries to prevent memory leaks
    private static void PerformCleanupIfNeeded()
    {
        var now = DateTime.UtcNow;
        if (now - _lastCleanup < CleanupInterval)
            return;

        _lastCleanup = now;
        var cutoffTime = now - WindowDuration;

        var keysToRemove = new List<string>();

        foreach (var kvp in _requestHistory)
        {
            var requestQueue = kvp.Value;
            lock (requestQueue)
            {
                // Remove old requests
                while (requestQueue.Count > 0 && requestQueue.Peek() <= cutoffTime)
                {
                    requestQueue.Dequeue();
                }

                // If queue is empty, mark for removal
                if (requestQueue.Count == 0)
                {
                    keysToRemove.Add(kvp.Key);
                }
            }
        }

        // Remove empty entries
        foreach (var key in keysToRemove)
        {
            _requestHistory.TryRemove(key, out _);
        }
    }

    /// Determines if rate limiting should be skipped for certain endpoints
    private bool ShouldSkipRateLimit(PathString path)
    {
        // Skip rate limiting for health checks, metrics, etc.
        var pathValue = path.Value?.ToLower();
        return pathValue?.StartsWith("/health") == true ||
                pathValue?.StartsWith("/metrics") == true ||
                pathValue?.StartsWith("/ping") == true;
    }

    /// Gets the current configuration
    public static int GetMaxRequestsPerMinute()
    {
        return MaxRequestsPerMinute;
    }
}