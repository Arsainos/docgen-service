﻿using docgen_service.Database;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.EntityFrameworkCore;

namespace docgen_service.Configurations
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get;}
        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder
                    .SetIsOriginAllowed((host) => true)
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials());
            });

            services.AddControllers();
            services.AddSwagger(Configuration);
            services.ConfigureAppSettings(Configuration);
            services.ConfigureTransientServices(Configuration);
            services.ConfigureScopedServices(Configuration);
            services.ConfigureSingletonServices(Configuration);
            services.AddEndpointsApiExplorer();

            services.AddDbContext<DataContext>
                (
                    options => options.UseNpgsql(
                        $"Host={Configuration.GetValue<string>("DataBase:Host")};" +
                        $"Port={Configuration.GetValue<string>("DataBase:Port")};" +
                        $"Database={Configuration.GetValue<string>("DataBase:Database")};" +
                        $"Username={Configuration.GetValue<string>("DataBase:Username")};" +
                        $"Password={Configuration.GetValue<string>("DataBase:Password")};"
                        )
                );
        }   

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
            });

            app.UseSwagger();
            app.UseSwaggerUI();

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseCors("CorsPolicy");

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {                
                endpoints.MapControllers();
            });
        }
    }
}
