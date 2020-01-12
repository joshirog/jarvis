using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using setours.jarvis.infrastructure.persistence;
using setours.jarvis.services.api.Extensions.Contract;

namespace setours.jarvis.services.api.Extensions.Startup
{
    public class DatabaseStartupExtension : IStartupExtension
    {
        public void ExtensionServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(
                options => options.UseNpgsql(configuration.GetConnectionString("DbConnection"))
            );
        }
    }
}
