using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace setours.jarvis.infrastructure.persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            /*ASPNETCORE_ENVIRONMENT="Local"; export ASPNETCORE_ENVIRONMENT*/
            /*echo $ASPNETCORE_ENVIRONMENT*/
            var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(Directory.GetCurrentDirectory() + $"/../setours.jarvis.services.api/appsettings.{environment}.json")
                .Build();

            return new ApplicationDbContext(new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseNpgsql(configuration.GetConnectionString("DbConnection"))
                .Options);
        }
    }
}
