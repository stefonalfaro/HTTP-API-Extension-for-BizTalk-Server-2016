using System.Net;
using Microsoft.AspNetCore.Http;
using System;
using System.Linq;
using Microsoft.Extensions.Primitives;

public class NetworkTools 
{
    public static IPAddress GetClientIPAddress(HttpContext context)
    {
        // Check for forwarded headers first (if behind proxy/load balancer)
        var forwardedFor = context.Request.Headers["X-Forwarded-For"].FirstOrDefault();
        if (!string.IsNullOrEmpty(forwardedFor))
        {
            var ips = forwardedFor.Split(',', StringSplitOptions.RemoveEmptyEntries);
            if (ips.Length > 0 && IPAddress.TryParse(ips[0].Trim(), out var forwardedIP))
            {
                return forwardedIP;
            }
        }

        // Check X-Real-IP header
        var realIP = context.Request.Headers["X-Real-IP"].FirstOrDefault();
        if (!string.IsNullOrEmpty(realIP) && IPAddress.TryParse(realIP, out var parsedRealIP))
        {
            return parsedRealIP;
        }

        // Fall back to connection remote IP
        return context.Connection.RemoteIpAddress ?? IPAddress.None;
    }

    public static bool IsFromLAN(IPAddress clientIP)
    {
        if (clientIP == null) return false;

        var bytes = clientIP.GetAddressBytes();
        
        // IPv4 checks
        if (clientIP.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
        {
            // 127.x.x.x (localhost)
            if (bytes[0] == 127) return true;
            
            // 10.x.x.x
            if (bytes[0] == 10) return true;
            
            // 172.16.x.x to 172.31.x.x
            if (bytes[0] == 172 && bytes[1] >= 16 && bytes[1] <= 31) return true;
            
            // 192.168.x.x
            if (bytes[0] == 192 && bytes[1] == 168) return true;
        }
        
        // IPv6 localhost
        if (clientIP.Equals(IPAddress.IPv6Loopback)) return true;

        return false;
    }
}