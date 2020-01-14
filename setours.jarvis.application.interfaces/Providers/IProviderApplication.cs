using setours.jarvis.application.dto.Providers;
using setours.jarvis.transversal.common.Bases.Querys;
using setours.jarvis.transversal.common.Bases.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace setours.jarvis.application.interfaces.Providers
{
    public interface IProviderApplication : IBaseApplication<ProviderDto>
    {
        Task<BaseApiResponse<IEnumerable<ProviderDto>>> GetSearch2(BaseSearchQuery search);
    }
}
