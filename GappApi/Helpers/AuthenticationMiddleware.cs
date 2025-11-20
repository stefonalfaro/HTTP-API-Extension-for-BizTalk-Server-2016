  using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Net;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Primitives;

public class AuthenticationMiddleware
{
    private readonly ILogger<AuthenticationMiddleware> log;
    private readonly IConfiguration configuration;
    public const string UserItemKey = "CurrentUser"; // Key for storing the user in HttpContext.Items
    public static string Environment = "Unknown";
    
    private readonly RequestDelegate _next;
    public AuthenticationMiddleware(RequestDelegate next, ILogger<AuthenticationMiddleware> _log, IConfiguration _configuration)
    {
        _next = next;
        log = _log;
        configuration = _configuration;
    }

    public async Task Invoke(HttpContext context, IConfiguration _configuration)
    {
        var clientIP = NetworkTools.GetClientIPAddress(context);
        bool isLAN = NetworkTools.IsFromLAN(clientIP);

        //CORS often uses this and should not be blocked by auth
        if (context.Request.Method == "OPTIONS")
        {
            await _next(context);
            return;
        }

        // Read the X-Device-Type header
        string deviceType = "unknown";
        if (context.Request.Headers.TryGetValue("X-Device-Type", out var deviceTypeHeader))
        {
            deviceType = deviceTypeHeader.FirstOrDefault() ?? "unknown";
        }

        if (context.Request.Path.ToString().Contains("/myhub") || context.Request.Path.ToString().Contains("/swagger") || context.Request.Path.ToString().Contains("/about"))
        {
            await _next.Invoke(context);
            return;
        }

        if (context.Request.Headers.TryGetValue("X-API-Key", out var APIKey) && !StringValues.IsNullOrEmpty(APIKey))
        {
            log.LogDebug($"[AuthenticationMiddleware] Attempting API Key authentication for {APIKey}");

            //TODO: Make an Admin API keys table or general API keys table
            if (APIKey == _configuration["APIKey"])
            {
                context.Items["Admin"] = true;
                await _next.Invoke(context);
            }
        }
        else
        {
            // no authorization header
            context.Response.StatusCode = 401; //Unauthorized
            return;
        }
    }
}