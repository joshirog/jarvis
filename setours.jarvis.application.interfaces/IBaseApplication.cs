using System.Collections.Generic;
using System.Threading.Tasks;
using setours.jarvis.application.dto;
using setours.jarvis.transversal.common.Bases.Querys;
using setours.jarvis.transversal.common.Bases.Requests;
using setours.jarvis.transversal.common.Bases.Responses;

namespace setours.jarvis.application.interfaces
{
    public interface IBaseApplication<TDataTranferObject> where TDataTranferObject : class, IDataTransferObject
    {
        Task<BaseApiResponse<TDataTranferObject>> GetByIdAsync(int id);

        Task<BaseApiResponse<IEnumerable<TDataTranferObject>>> GetAllAsync();

        Task<BaseApiResponse<IEnumerable<TDataTranferObject>>> GetSearchAsync(BaseSearchQuery search);

        Task<BaseApiResponse<TDataTranferObject>> InsertAsync(BaseApiRequest<TDataTranferObject> entity);

        Task<BaseApiResponse<IEnumerable<TDataTranferObject>>> InsertBulkAsync(BaseApiRequest<IEnumerable<TDataTranferObject>> entities);

        Task<BaseApiResponse<TDataTranferObject>> UpdateAsync(BaseApiRequest<TDataTranferObject> entity);

        Task<BaseApiResponse<IEnumerable<TDataTranferObject>>> UpdateBulkAsync(BaseApiRequest<IEnumerable<TDataTranferObject>> entities);

        Task<BaseApiResponse<TDataTranferObject>> DeleteAsync(BaseApiRequest<TDataTranferObject> entity);

        Task<BaseApiResponse<IEnumerable<TDataTranferObject>>> DeleteBulkAsync(BaseApiRequest<IEnumerable<TDataTranferObject>> entities);
    }
}
