# HTTP API Extension for BizTalk Server 2016
This is designed to integrate with Microsoft BizTalk Server 2016 extending the platform to provide HTTP APIs allowing better oversight into EDI workflows and configurations. This is a significant enhancement to the Windows Form bulky and slow UI that exists. 

## Configuration
Point the ConnectionString in `appsettings.json` to your BizTalk database on your SQL Server. `Data Source=192.168.2.66; Initial Catalog=BizTalkMgmtDb;`

You should use a separate user for this and grant it read only permission.
```
USE [BizTalkMgmtDb6];
CREATE USER [WarehouseUser] FOR LOGIN [WarehouseUser];
ALTER ROLE db_datareader ADD MEMBER [WarehouseUser];
GO
```

### AppSettings
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Data Source=192.168.1.5; Initial Catalog=BizTalkMgmtDb; User Id=WarehouseUser; Password=password123;"
  },
  "MaxRequestsPerMinute":500,
  "AllowedHosts": "*",
  "APIKey":""
}
```

### Authentication from Frontend Clients
Add a header for `X-API-Key` and set the value to the APIKey you set in your `appsettings.json`
```
GET /TradingPartners HTTP/1.1
Host: localhost:5101
X-API-Key: SD24JH234KHJ24KJH34KJH23JK4HKJ23
```

### Rate Limits
The standard class I use as a middleware in all my .NET WebAPIs is `GlobalRateLimiter.cs`. This applies a rate limit per IP based on the Requests per Minute set in your configuration.


## Endpoints
Swagger `http://localhost:5101/swagger/index.html`

| Resource | Endpoints |
|----------|-----------|
| Adapters | GET /Adapters<br>GET /Adapters/{id} |
| Agreements | GET /Agreements<br>GET /Agreements/{id} |
| Components | GET /Components<br>GET /Components/{id} |
| Orchestration | GET /Orchestration<br>GET /Orchestration/{id} |
| TradingPartners | GET /TradingPartners<br>GET /TradingPartners/{id} |
| X12Protocols | GET /X12Protocols<br>GET /X12Protocols/{id} |

## Author

**Stefon Alfaro**  
[stefonalfaro@gmail.com](mailto:stefonalfaro@gmail.com) • [stefonalfaro.com](https://stefonalfaro.com/)