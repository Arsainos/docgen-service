using docgen_service.Configurations.AppSettings;
using Microsoft.OpenApi.Models;

namespace docgen_service.Configurations
{
    public static class CustomServiceExtensions
    {
        public static IServiceCollection AddSwagger(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Documents.Api",
                    Version = "v1",
                    Description = "Сервис работы с преобразоваием документов"
                });

                // добавить в случае авторизации
                /*
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = $"JWT Authorization header using the Bearer scheme. Enter 'Bearer' {Environment.NewLine} [space] and then your token in the text input below. {Environment.NewLine} Example: 'Bearer 12345abcdef'",
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    In = ParameterLocation.Header,
                    Scheme = "Bearer"
                });
                
                c.AddSecurityRequirement(new OpenApiSecurityRequirement()
                {
                    {
                        new OpenApiSecurityScheme
                        {
                        Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            },
                            Scheme = "oauth2",
                            Name = "Bearer",
                            In = ParameterLocation.Header,

                        },
                    new List<string>()
                }});
                */

                var basePath = AppContext.BaseDirectory;

                c.IncludeXmlComments(basePath + "docgen-service.xml");
            });

            return services;
        }

        public static IServiceCollection ConfigureAppSettings(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<Logging>(configuration.GetSection("Logging"));
            services.Configure<DataBase>(configuration.GetSection("DataBase"));

            return services;
        }

        public static IServiceCollection ConfigureTransientServices(this IServiceCollection services, IConfiguration configuration)
        {
            return services;
        }

        public static IServiceCollection ConfigureScopedServices(this IServiceCollection services, IConfiguration configuration)
        {
            return services;
        }

        public static IServiceCollection ConfigureSingletonServices(this IServiceCollection services, IConfiguration configuration)
        {
            return services;
        }
    }
}
