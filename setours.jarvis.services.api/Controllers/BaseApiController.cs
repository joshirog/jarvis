using Microsoft.AspNetCore.Mvc;
using setours.jarvis.application.dto;
using setours.jarvis.application.interfaces;
using setours.jarvis.transversal.common.Bases.Querys;
using setours.jarvis.transversal.common.Bases.Requests;
using setours.jarvis.transversal.common.Constants.Uri;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace setours.jarvis.services.api.Controllers
{
    public abstract class BaseApiController<TApplication, TDataTransferObject> : ControllerBase
        where TDataTransferObject : class, IDataTransferObject
        where TApplication : IBaseApplication<TDataTransferObject>
    {
        protected readonly TApplication _application;

        public BaseApiController(TApplication application)
        {
            _application = application;
        }

        [HttpGet()]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await _application.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            return Ok(await _application.GetByIdAsync(id));
        }

        [HttpGet(ControllerUri.URI_SEARCH)]
        public async Task<IActionResult> GetSearchAsync([FromQuery] BaseSearchQuery search)
        {
            return Ok(await _application.GetSearchAsync(search));
        }

        [HttpPost()]
        public async Task<IActionResult> InsertAsync([FromBody] BaseApiRequest<TDataTransferObject> request)
        {
            return Ok(await _application.InsertAsync(request));
        }

        [HttpPost(ControllerUri.URI_BULK)]
        public async Task<IActionResult> InsertBulkAsync([FromBody] BaseApiRequest<IEnumerable<TDataTransferObject>> request)
        {
            return Ok(await _application.InsertBulkAsync(request));
        }

        [HttpPut()]
        public async Task<IActionResult> UpdateAsync([FromBody] BaseApiRequest<TDataTransferObject> request)
        {
            return Ok(await _application.UpdateAsync(request));
        }

        [HttpPut(ControllerUri.URI_BULK)]
        public async Task<IActionResult> UpdateBulkAsync([FromBody] BaseApiRequest<IEnumerable<TDataTransferObject>> request)
        {
            return Ok(await _application.UpdateBulkAsync(request));
        }

        [HttpDelete()]
        public async Task<IActionResult> DeleteAsync([FromBody] BaseApiRequest<TDataTransferObject> request)
        {
            return Ok(await _application.DeleteAsync(request));
        }

        [HttpDelete(ControllerUri.URI_BULK)]
        public async Task<IActionResult> DeleteBulkAsync([FromBody] BaseApiRequest<IEnumerable<TDataTransferObject>> request)
        {
            return Ok(await _application.DeleteBulkAsync(request));
        }
    }
}
