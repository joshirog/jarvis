using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using setours.jarvis.application.interfaces.Providers;
using setours.jarvis.application.main.Providers;
using setours.jarvis.application.validation.Providers;
using setours.jarvis.domain.core.Providers;
using setours.jarvis.domain.interfaces.Providers;
using setours.jarvis.infrastructure.interfaces.Providers;
using setours.jarvis.infrastructure.persistence;
using setours.jarvis.infrastructure.repository.Providers;
using setours.jarvis.services.v1.api.Configurations.Settings;
using setours.jarvis.transversal.mapper;

namespace setours.jarvis.services.v1.api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddDbContext<ApplicationDbContext>(
                options => options.UseNpgsql(Configuration.GetConnectionString("DbConnection"))
            );

            services.AddRouting(options => options.LowercaseUrls = true);

            services.AddControllers().AddNewtonsoftJson(
                options =>
                {
                    options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                    options.SerializerSettings.ContractResolver = new DefaultContractResolver() { NamingStrategy = new SnakeCaseNamingStrategy() };
                }
            );

            services.AddSingleton(new MapperConfiguration(x => {
                x.AddProfile(new MappingsProfile());
            }).CreateMapper());



            services.AddScoped<IProviderStatusApplication, ProviderStatusApplication>();
            services.AddScoped<ProviderStatusValidation>();
            services.AddScoped<IProviderStatusDomain, ProviderStatusDomain>();
            services.AddScoped<IProviderStatusRepository, ProviderStatusRepository>();

            services.AddSwaggerGen(x => {
                x.SwaggerDoc("v1", new OpenApiInfo()
                {
                    Title = "Jarvis API",
                    Version = "v1",
                    Description = "Microservice from core bussiness Setours",
                    TermsOfService = new Uri("https://opensource.org/licenses/MIT"),
                    Contact = new OpenApiContact()
                    {
                        Name = "Jose Oshiro",
                        Email = "jose.oshiro@setours.com",
                        Url = new Uri("https://github.com/joshirog")
                    },
                    License = new OpenApiLicense
                    {
                        Name = "Use under LICX",
                        Url = new Uri("https://opensource.org/licenses/MIT")
                    }
                });

                /*
                var security = new Dictionary<string, IEnumerable<string>>
                {
                    { "Bearer", new string[0] }
                };

                x.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
                {
                    Description = "JWT Authorization header suing bearer scheme",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey
                });
                x.AddSecurityRequirement(new OpenApiSecurityRequirement()
                {
                    { new OpenApiSecurityScheme() {
                        Reference = new OpenApiReference(){
                            Id = "Bearer",
                            Type = ReferenceType.SecurityScheme
                        }
                    }, new List<string>() }
                });
                */
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment() || env.IsEnvironment("Local"))
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            var swagger = new SwaggerSettings();
            Configuration.GetSection(nameof(SwaggerSettings)).Bind(swagger);

            app.UseSwagger(option =>
            {
                option.RouteTemplate = swagger.JsonRoute;
            });

            app.UseSwaggerUI(option =>
            {
                option.SwaggerEndpoint(swagger.UiEndpoint, swagger.Decription);
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
