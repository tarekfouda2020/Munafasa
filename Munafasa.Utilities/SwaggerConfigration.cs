﻿using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using Swashbuckle.AspNetCore.SwaggerUI;

namespace Munafasa.Utilities
{
    public class SwaggerConfigration : IConfigureOptions<SwaggerGenOptions>
    {
        public void Configure(SwaggerGenOptions c)
        {
            var info = new OpenApiInfo
            {
                Title = "Munafasa",
                Version = "v1",
                Description = " Auth APIs for the mobile",
            };

            c.SwaggerDoc("Auth", info);
            c.SwaggerDoc("Service", info);
            c.SwaggerDoc("Request", info);
            c.SwaggerDoc("Contract", info);

            c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
            {
                Name = "Authorization",
                Type = SecuritySchemeType.ApiKey,
                Scheme = "Bearer",
                BearerFormat = "JWT",
                In = ParameterLocation.Header,
            });
            c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                          new OpenApiSecurityScheme
                            {
                                Reference = new OpenApiReference
                                {
                                    Type = ReferenceType.SecurityScheme,
                                    Id = "Bearer"
                                }
                            },
                            new string[] {}

                    }
                });
        }
    }
    public class SwaggerUIConfiguration : IConfigureOptions<SwaggerUIOptions>
    {
        public void Configure(SwaggerUIOptions options)
        {

            options.RoutePrefix = "Swagger";
            options.SwaggerEndpoint("/swagger/Auth/swagger.json", "Auth APIs");
            options.SwaggerEndpoint("/swagger/Service/swagger.json", "Service APIs");
            options.SwaggerEndpoint("/swagger/Request/swagger.json", "Request APIs");
            options.SwaggerEndpoint("/swagger/Contract/swagger.json", "Contract APIs");



        }
    }
}

