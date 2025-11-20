using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.SwaggerGen;
using Microsoft.OpenApi.Models;
using Microsoft.Extensions.DependencyInjection;
using System;

public class ConfigureSwaggerOptions : IConfigureOptions<SwaggerGenOptions>
{
    private readonly IApiVersionDescriptionProvider _provider;

    public ConfigureSwaggerOptions(IApiVersionDescriptionProvider provider)
    {
        _provider = provider;
    }

    public void Configure(SwaggerGenOptions options)
    {
        foreach (var description in _provider.ApiVersionDescriptions)
        {
            options.SwaggerDoc(description.GroupName, new OpenApiInfo
            {
                Title = "GAPP EDI API",
                Version = description.ApiVersion.ToString(),
                Description = "For BizTalk Server 2016",
                TermsOfService = new Uri("https://erp.gappexpress.com/terms"),
                Contact = new OpenApiContact
                {
                    Name = "Stefon Alfaro",
                    Email = "stefon@gappexpress.com"
                }
            });
        }

        options.CustomSchemaIds(type => type.FullName); // keep your schemaId fix
    }
}
