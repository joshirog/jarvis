using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace setours.jarvis.services.api.Extensions.Contract
{
    public interface IStartupExtension
    {
        void ExtensionServices(IServiceCollection services, IConfiguration configuration);
    }
}
