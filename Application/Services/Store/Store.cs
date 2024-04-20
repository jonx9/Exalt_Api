using Application.Common.Response;
using Application.Cqrs.IndicatorType.Commands;
using Application.Cqrs.IndicatorType.Querys;
using Application.Cqrs.Store.Querys;
using Application.Cqrs.User.Commands;
using Application.DTOs.Store;
using Application.DTOs.User;
using Application.Interfaces.Store;
using AutoMapper;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Store
{
    public class Store : IStore
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public Store(IUnitOfWork unitOfWork,
                                    IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ApiResponse<bool>> DeleteIndicatorType(DeleteIndicatorTypeCommand request)
        {
            var response = new ApiResponse<bool>();
            try
            {
                var Store = await _unitOfWork.StoreRepository.GetById(request.Id);

                response.Data = await _unitOfWork.StoreRepository.Delete(Store);
                response.Result = true;
                response.Message = "Ok";
            }
            catch (Exception ex)
            {
                response.Result = false;
                response.Message = $"Error al eliminar el registro, consulte con el administrador. {ex.Message}";
                throw;
            }
            return response;
        }

        public async Task<ApiResponse<List<StoreDtoQuery>>> GetIndicatorsType(GetIndicatorTypeQuery request, CancellationToken cancellationToken)
        {
            var response = new ApiResponse<List<StoreDtoQuery>>();
            try
            {
                DateTime? ReportDateInit = null;
                DateTime? ReportDateEnd = null;

                if (request.ReportDate != null)
                {
                    ReportDateInit = DateTime.Parse(request.ReportDate);
                    ReportDateEnd = ReportDateInit.Value.AddDays(1);
                }
                

                response.Data = _mapper.Map<List<StoreDtoQuery>>(_unitOfWork.StoreRepository.Get()
                                                                                                .Where(x => x.Estado == request.Estado || request.Estado == null)
                                                                                                .Where(x => (x.CreatedAt >= ReportDateInit && x.CreatedAt <= ReportDateEnd) || request.ReportDate == null)
                                                                                                .ToList());
            }
            catch (Exception ex)
            {
                response.Result = false;
                response.Message = $"Error al actualizar el registro, consulte con el administrador. {ex.Message} ";
                throw;
            }
            return response;
        }

        public async Task<ApiResponse<StoreDto>> PostIndicatorType(PostIndicatorTypeCommand request, CancellationToken cancellationToken)
        {
            var response = new ApiResponse<StoreDto>();
            try
            {
                response.Data = _mapper.Map<StoreDto>(await _unitOfWork.StoreRepository.Add(_mapper.Map<Domain.Models.Store.Store>(request.StoreDto)));
            }
            catch (Exception ex)
            {
                response.Result = false;
                response.Message = $"Error al actualizar el registro, consulte con el administrador. {ex.Message} ";
                throw;
            }
            return response;
        }

        public async Task<ApiResponse<StoreDtoQuery>> PutIndicatorType(PutIndicatorTypeCommand request, CancellationToken cancellationToken)
        {
            var response = new ApiResponse<StoreDtoQuery>();
            try
            {
                response.Data = _mapper.Map<StoreDtoQuery>(await _unitOfWork.StoreRepository.Put(_mapper.Map<Domain.Models.Store.Store>(request.StoreDtoQuery)));
            }
            catch (Exception ex)
            {
                response.Result = false;
                response.Message = $"Error al actualizar el registro, consulte con el administrador. {ex.Message} ";
                throw;
            }
            return response;
        }

        public async Task<ApiResponse<StoreDtoQuery>> GetIndicatorTypeById(GetIndicatorTypeByIdQuery request)
        {
            var response = new ApiResponse<StoreDtoQuery>();

            try
            {
                response.Data = _mapper.Map<StoreDtoQuery>(_unitOfWork.StoreRepository.Get()
                                                                                          .Where(x => x.Id == request.Id)
                                                                                          .FirstOrDefault());
                response.Result = true;
                response.Message = "OK";
            }
            catch (Exception ex)
            {
                response.Result = false;
                response.Message = $"Error al Consultar el registro, consulte con el administrador. {ex.Message} ";
            }

            return response;
        }

        public async Task<ApiResponse<List<StoreDtoQuery>>> GetAllIndicatorsType()
        {
            var response = new ApiResponse<List<StoreDtoQuery>>();
            try
            {

                response.Data = _mapper.Map<List<StoreDtoQuery>>(_unitOfWork.StoreRepository.Get().ToList());
                response.Result = true;
                response.Message = "OK";


            }
            catch (Exception ex)
            {
                response.Result = false;
                response.Message = $"Error al actualizar el registro, consulte con el administrador. {ex.Message} ";

            }
            return response;
        }
    }
}
