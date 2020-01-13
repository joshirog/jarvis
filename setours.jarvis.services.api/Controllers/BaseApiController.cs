using Microsoft.AspNetCore.Mvc;
using setours.jarvis.application.dto;
using setours.jarvis.application.interfaces;
using setours.jarvis.transversal.common.Bases.Querys;
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

        [HttpGet("Search")]
        public async Task<IActionResult> GetSearch(BaseSearchQuery search)
        {
            return Ok(await _application.GetSearch(search));
        }

        [HttpPost()]
        public async Task<IActionResult> InsertAsync([FromBody] TDataTransferObject dto)
        {
            return Ok(await _application.InsertAsync(dto));
        }

        [HttpPost("bulk")]
        public async Task<IActionResult> InsertBulkAsync([FromBody] IEnumerable<TDataTransferObject> dtos)
        {
            return Ok(await _application.InsertBulkAsync(dtos));
        }

        [HttpPut()]
        public async Task<IActionResult> UpdateAsync([FromBody] TDataTransferObject dto)
        {
            return Ok(await _application.UpdateAsync(dto));
        }

        [HttpPut("bulk")]
        public async Task<IActionResult> UpdateBulkAsync([FromBody] IEnumerable<TDataTransferObject> dtos)
        {
            return Ok(await _application.UpdateBulkAsync(dtos));
        }

        [HttpDelete()]
        public async Task<IActionResult> DeleteAsync([FromBody] TDataTransferObject dto)
        {
            return Ok(await _application.DeleteAsync(dto));
        }

        [HttpDelete("bulk")]
        public async Task<IActionResult> DeleteBulkAsync([FromBody] IEnumerable<TDataTransferObject> dtos)
        {
            return Ok(await _application.DeleteBulkAsync(dtos));
        }
    }
}
