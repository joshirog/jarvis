using System;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using setours.jarvis.application.interfaces.Generals;
using setours.jarvis.application.interfaces.Providers;
using setours.jarvis.application.main.Generals;
using setours.jarvis.application.main.Providers;
using setours.jarvis.application.validation.Generals;
using setours.jarvis.application.validation.Providers;
using setours.jarvis.domain.core.Generals;
using setours.jarvis.domain.core.Providers;
using setours.jarvis.domain.interfaces.Generals;
using setours.jarvis.domain.interfaces.Providers;
using setours.jarvis.infrastructure.interfaces.Generals;
using setours.jarvis.infrastructure.interfaces.Providers;
using setours.jarvis.infrastructure.persistence;
using setours.jarvis.infrastructure.repository.Generals;
using setours.jarvis.infrastructure.repository.Providers;
using setours.jarvis.transversal.mapper;

namespace setours.jarvis.services.api
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

            services.AddSingleton(new MapperConfiguration(x => {
                x.AddProfile(new MappingsProfile());
            }).CreateMapper());

            services.AddRouting(options => options.LowercaseUrls = true);

            services.AddControllers().AddNewtonsoftJson(
                options =>
                {
                    options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                    options.SerializerSettings.ContractResolver = new DefaultContractResolver() { NamingStrategy = new SnakeCaseNamingStrategy() };
                }
            );

            services.AddScoped<IDocumentApplication, DocumentApplication>();
            services.AddScoped<DocumentValidation>();
            services.AddScoped<IDocumentDomain, DocumentDomain>();
            services.AddScoped<IDocumentRepository, DocumentRepository>();

            services.AddScoped<ILocationApplication, LocationApplication>();
            services.AddScoped<LocationValidation>();
            services.AddScoped<ILocationDomain, LocationDomain>();
            services.AddScoped<ILocationRepository, LocationRepository>();

            services.AddScoped<IProviderStatusApplication, ProviderStatusApplication>();
            services.AddScoped<ProviderStatusValidation>();
            services.AddScoped<IProviderStatusDomain, ProviderStatusDomain>();
            services.AddScoped<IProviderStatusRepository, ProviderStatusRepository>();

            services.AddScoped<IProviderChainApplication, ProviderChainApplication>();
            services.AddScoped<ProviderChainValidation>();
            services.AddScoped<IProviderChainDomain, ProviderChainDomain>();
            services.AddScoped<IProviderChainRepository, ProviderChainRepository>();

            services.AddScoped<IProviderApplication, ProviderApplication>();
            services.AddScoped<ProviderValidation>();
            services.AddScoped<IProviderDomain, ProviderDomain>();
            services.AddScoped<IProviderRepository, ProviderRepository>();

            /*
            services.AddCors();

            services.AddCors(c =>
            {
                c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin());
                c.AddPolicy("AllowMethod", options => options.AllowAnyMethod());
                c.AddPolicy("AllowCredentials", options => options.AllowCredentials());
                c.AddPolicy("AllowHeader", options => options.AllowAnyHeader());
            });
            */

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
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment() || env.IsEnvironment("Local"))
            {
                app.UseDeveloperExceptionPage();
            }

            /*
            app.UseCors(
                builder => builder
                    .AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials()
            );
            */

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();

            app.UseSwaggerUI(option =>
            {
                option.SwaggerEndpoint("/swagger/v1/swagger.json", "Jarvis API");
            });
        }
    }
}
