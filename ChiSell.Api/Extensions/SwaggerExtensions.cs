using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Swagger;
using System;
using System.IO;
using System.Reflection;

namespace ChiSell.Api.Extensions
{
    /// <summary>
    /// Extensions for Swagger
    /// </summary>
    public static class SwaggerExtensions
    {
        /// <summary>
        /// Adds Swagger Documentation
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddSwaggerDocumentation(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", GetSwaggerMetadata());
                var xmlFile = $"{Assembly.GetEntryAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                if (File.Exists(xmlPath))
                {
                    c.IncludeXmlComments(xmlPath);
                }
            });

            return services;
        }

        private static OpenApiInfo GetSwaggerMetadata()
        {
            
            return new OpenApiInfo
            {
                Title = "Resume API",
                Version = "v1",
                Description = "Provides endpoint for resumes",
                Contact = new OpenApiContact
                {
                    Name = "Luis Sosa",
                    Email = "lmsosa@gmail.com"
                },
                License = new OpenApiLicense
                {
                    Name = "PRIVATE"
                }
            };
        }
    }
}
