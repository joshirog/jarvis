using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using setours.jarvis.application.dto;
using setours.jarvis.application.interfaces;
using setours.jarvis.application.validation;
using setours.jarvis.domain.entity;
using setours.jarvis.domain.interfaces;
using setours.jarvis.transversal.common.Bases.Querys;
using setours.jarvis.transversal.common.Bases.Responses;
using setours.jarvis.transversal.common.Constants.Messages;

namespace setours.jarvis.application.main
{
    public abstract class BaseApplication<TDomain, TDataTransferObject, TEntity, TValidation>
        : IBaseApplication<TDataTransferObject>
        where TDataTransferObject : class, IDataTransferObject
        where TEntity : class, IEntity
        where TDomain : IBaseDomain<TEntity>
        where TValidation : BaseValidation<TDataTransferObject>
    {

        private readonly TDomain _domain;
        private readonly IMapper _mapper;
        private readonly TValidation _validation;

        public BaseApplication(TDomain domain, IMapper mapper, TValidation validation)
        {
            _domain = domain;
            _mapper = mapper;
            _validation = validation;
        }

        public async Task<BaseApiResponse<TDataTransferObject>> GetByIdAsync(int id)
        {
            var response = new BaseApiResponse<TDataTransferObject>();

            try
            {
                var result = await _domain.GetByIdAsync(id);

                response.IsSuccess = ApplicationMessage.IS_SUCCESS;
                response.Data = _mapper.Map<TDataTransferObject>(result);
                response.Message = ApplicationMessage.MESSAGE_SUCCESS;
            }
            catch (Exception ex)
            {
                response.Message = ApplicationMessage.MESSAGE_ERROR;
                response.Exception = $"{ex.Message} - {ex.InnerException.Message}";
            }

            return response;
        }

        public async Task<BaseApiResponse<IEnumerable<TDataTransferObject>>> GetAllAsync()
        {
            var response = new BaseApiResponse<IEnumerable<TDataTransferObject>>();

            try
            {
                var result = await _domain.GetAllAsync();

                response.IsSuccess = ApplicationMessage.IS_SUCCESS;
                response.Data = _mapper.Map<IEnumerable<TDataTransferObject>>(result);
                response.Message = ApplicationMessage.MESSAGE_SUCCESS;
            }
            catch (Exception ex)
            {
                response.Message = ApplicationMessage.MESSAGE_ERROR;
                response.Exception = $"{ex.Message} - {ex.InnerException.Message}";
            }

            return response;
        }

        public async Task<BaseApiResponse<IEnumerable<TDataTransferObject>>> GetSearch(BaseSearchQuery search)
        {
            var response = new BaseApiResponse<IEnumerable<TDataTransferObject>>();

            try
            {
                var result = await _domain.GetSearch(search);

                response.IsSuccess = ApplicationMessage.IS_SUCCESS;
                response.Data = _mapper.Map<IEnumerable<TDataTransferObject>>(result);
                response.Message = ApplicationMessage.MESSAGE_SUCCESS;
            }
            catch (Exception ex)
            {
                response.Message = ApplicationMessage.MESSAGE_ERROR;
                response.Exception = $"{ex.Message} - {ex.InnerException.Message}";
            }

            return response;
        }

        public async Task<BaseApiResponse<TDataTransferObject>> InsertAsync(TDataTransferObject dto)
        {
            var response = new BaseApiResponse<TDataTransferObject>();

            try
            {
                var validation = _validation.Validate(dto);

                if (!validation.IsValid)
                {
                    response.Message = ApplicationMessage.MESSAGE_ERROR_VALIDATOR;
                    response.ValidationErrors = validation.Errors;
                    return response;
                }

                var entity = _mapper.Map<TEntity>(dto);

                var result = await _domain.InsertAsync(entity);

                response.IsSuccess = ApplicationMessage.IS_SUCCESS;
                response.Data = _mapper.Map<TDataTransferObject>(result);
                response.Message = ApplicationMessage.MESSAGE_SUCCESS;
            }
            catch (Exception ex)
            {
                response.Message = ApplicationMessage.MESSAGE_ERROR;
                response.Exception = $"{ex.Message} - {ex.InnerException.Message}";
            }

            return response;
        }

        public async Task<BaseApiResponse<IEnumerable<TDataTransferObject>>> InsertBulkAsync(IEnumerable<TDataTransferObject> dtos)
        {
            var response = new BaseApiResponse<IEnumerable<TDataTransferObject>>();

            try
            {
                var entities = _mapper.Map<List<TEntity>>(dtos);

                var result = await _domain.InsertBulkAsync(entities);

                response.IsSuccess = ApplicationMessage.IS_SUCCESS;
                response.Data = _mapper.Map<IEnumerable<TDataTransferObject>>(result);
                response.Message = ApplicationMessage.MESSAGE_SUCCESS;
            }
            catch (Exception ex)
            {
                response.Message = ApplicationMessage.MESSAGE_ERROR;
                response.Exception = $"{ex.Message} - {ex.InnerException.Message}";
            }

            return response;
        }

        public async Task<BaseApiResponse<TDataTransferObject>> UpdateAsync(TDataTransferObject dto)
        {
            var response = new BaseApiResponse<TDataTransferObject>();

            try
            {
                var validation = _validation.Validate(dto);

                if (!validation.IsValid)
                {
                    response.Message = ApplicationMessage.MESSAGE_ERROR_VALIDATOR;
                    response.ValidationErrors = validation.Errors;
                    return response;
                }

                var entity = _mapper.Map<TEntity>(dto);

                var result = await _domain.UpdateAsync(entity);

                response.IsSuccess = ApplicationMessage.IS_SUCCESS;
                response.Data = _mapper.Map<TDataTransferObject>(result);
                response.Message = ApplicationMessage.MESSAGE_SUCCESS;
            }
            catch (Exception ex)
            {
                response.Message = ApplicationMessage.MESSAGE_ERROR;
                response.Exception = $"{ex.Message} - {ex.InnerException.Message}";
            }

            return response;
        }

        public async Task<BaseApiResponse<IEnumerable<TDataTransferObject>>> UpdateBulkAsync(IEnumerable<TDataTransferObject> dtos)
        {
            var response = new BaseApiResponse<IEnumerable<TDataTransferObject>>();

            try
            {
                var entities = _mapper.Map<List<TEntity>>(dtos);

                var result = await _domain.UpdateBulkAsync(entities);

                response.IsSuccess = ApplicationMessage.IS_SUCCESS;
                response.Data = _mapper.Map<IEnumerable<TDataTransferObject>>(result);
                response.Message = ApplicationMessage.MESSAGE_SUCCESS;
            }
            catch (Exception ex)
            {
                response.Message = ApplicationMessage.MESSAGE_ERROR;
                response.Exception = $"{ex.Message} - {ex.InnerException.Message}";
            }

            return response;
        }

        public async Task<BaseApiResponse<TDataTransferObject>> DeleteAsync(TDataTransferObject dto)
        {
            var response = new BaseApiResponse<TDataTransferObject>();

            try
            {
                var validation = _validation.Validate(dto);

                if (!validation.IsValid)
                {
                    response.Message = ApplicationMessage.MESSAGE_ERROR_VALIDATOR;
                    response.ValidationErrors = validation.Errors;
                    return response;
                }

                var entity = _mapper.Map<TEntity>(dto);

                var result = await _domain.DeleteAsync(entity);

                response.IsSuccess = ApplicationMessage.IS_SUCCESS;
                response.Data = _mapper.Map<TDataTransferObject>(result);
                response.Message = ApplicationMessage.MESSAGE_SUCCESS;
            }
            catch (Exception ex)
            {
                response.Message = ApplicationMessage.MESSAGE_ERROR;
                response.Exception = $"{ex.Message} - {ex.InnerException.Message}";
            }

            return response;
        }

        public async Task<BaseApiResponse<IEnumerable<TDataTransferObject>>> DeleteBulkAsync(IEnumerable<TDataTransferObject> dtos)
        {
            var response = new BaseApiResponse<IEnumerable<TDataTransferObject>>();

            try
            {
                var entities = _mapper.Map<List<TEntity>>(dtos);

                var result = await _domain.DeleteBulkAsync(entities);

                response.IsSuccess = ApplicationMessage.IS_SUCCESS;
                response.Data = _mapper.Map<IEnumerable<TDataTransferObject>>(result);
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
