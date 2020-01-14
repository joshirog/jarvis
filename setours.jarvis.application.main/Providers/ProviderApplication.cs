using AutoMapper;
using setours.jarvis.application.dto.Providers;
using setours.jarvis.application.interfaces.Providers;
using setours.jarvis.application.validation.Providers;
using setours.jarvis.domain.entity.Providers;
using setours.jarvis.domain.interfaces.Providers;
using setours.jarvis.transversal.common.Bases.Querys;
using setours.jarvis.transversal.common.Bases.Responses;
using setours.jarvis.transversal.common.Constants.Messages;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace setours.jarvis.application.main.Providers
{
    public class ProviderApplication :
        BaseApplication<IProviderDomain, ProviderDto, ProviderEntity, ProviderValidation>, IProviderApplication
    {
        public ProviderApplication(IProviderDomain domain, IMapper mapper, ProviderValidation validation)
            : base(domain, mapper, validation)
        {

        }

        public async Task<BaseApiResponse<IEnumerable<ProviderDto>>> GetSearch2(BaseSearchQuery search)
        {
            var response = new BaseApiResponse<IEnumerable<ProviderDto>>();

            try
            {
                var result = await _domain.GetSearch2(search);

                response.IsSuccess = ApplicationMessage.IS_SUCCESS;
                response.Data = _mapper.Map<IEnumerable<ProviderDto>>(result);
                response.Message = ApplicationMessage.MESSAGE_SUCCESS;
            }
            catch (Exception ex)
            {
                response.Message = ApplicationMessage.MESSAGE_ERROR;
                response.Exception = $"{ex.Message} - {ex.InnerException.Message}";
            }

            return response;
        }
    }
}
