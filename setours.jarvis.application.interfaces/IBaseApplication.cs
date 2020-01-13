using System.Collections.Generic;
using System.Threading.Tasks;
using setours.jarvis.application.dto;
using setours.jarvis.transversal.common.Bases.Querys;
using setours.jarvis.transversal.common.Bases.Responses;

namespace setours.jarvis.application.interfaces
{
    public interface IBaseApplication<TDataTranferObject> where TDataTranferObject : class, IDataTransferObject
    {
        Task<BaseApiResponse<TDataTranferObject>> GetByIdAsync(int id);

        Task<BaseApiResponse<IEnumerable<TDataTranferObject>>> GetAllAsync();

        Task<BaseApiResponse<IEnumerable<TDataTranferObject>>> GetSearch(BaseSearchQuery search);

        Task<BaseApiResponse<TDataTranferObject>> InsertAsync(TDataTranferObject entity);

        Task<BaseApiResponse<IEnumerable<TDataTranferObject>>> InsertBulkAsync(IEnumerable<TDataTranferObject> entities);

        Task<BaseApiResponse<TDataTranferObject>> UpdateAsync(TDataTranferObject entity);

        Task<BaseApiResponse<IEnumerable<TDataTranferObject>>> UpdateBulkAsync(IEnumerable<TDataTranferObject> entities);

        Task<BaseApiResponse<TDataTranferObject>> DeleteAsync(TDataTranferObject entity);

        Task<BaseApiResponse<IEnumerable<TDataTranferObject>>> DeleteBulkAsync(IEnumerable<TDataTranferObject> entities);
    }
}
