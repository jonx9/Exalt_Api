using Application.Common.Response;
using Application.Cqrs.IndicatorType.Commands;
using Application.Cqrs.IndicatorType.Querys;
using Application.Cqrs.Sales.Querys;
using Application.Cqrs.Sales.Commands;
using Application.DTOs.Sales;
using Application.DTOs.User;
using Application.Interfaces.Store;
using Application.Interfaces.Sales;
using AutoMapper;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Sales
{
    public class Sales : ISales
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public Sales(IUnitOfWork unitOfWork,
                                    IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ApiResponse<bool>> SalesDeleteIndicatorType(SalesDeleteIndicatorTypeCommand request)
        {
            var response = new ApiResponse<bool>();
            try
            {
                var Sales = await _unitOfWork.SalesRepository.GetById(request.Id);

                response.Data = await _unitOfWork.SalesRepository.Delete(Sales);
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

        public async Task<ApiResponse<List<SalesDtoQuery>>> SalesGetIndicatorsType(SalesGetIndicatorTypeQuery request, CancellationToken cancellationToken)
        {
            var response = new ApiResponse<List<SalesDtoQuery>>();
            try
            {
                DateTime? ReportDateInit = null;
                DateTime? ReportDateEnd = null;

                if (request.ReportDate != null)
                {
                    ReportDateInit = DateTime.Parse(request.ReportDate);
                    ReportDateEnd = ReportDateInit.Value.AddDays(1);
                }


                response.Data = _mapper.Map<List<SalesDtoQuery>>(_unitOfWork.SalesRepository.Get()
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

        public async Task<ApiResponse<SalesDto>> SalesPostIndicatorType(SalesPostIndicatorTypeCommand request, CancellationToken cancellationToken)
        {
            var response = new ApiResponse<SalesDto>();
            try
            {
                response.Data = _mapper.Map<SalesDto>(await _unitOfWork.SalesRepository.Add(_mapper.Map<Domain.Models.Sales.Sales>(request.SalesDto)));
            }
            catch (Exception ex)
            {
                response.Result = false;
                response.Message = $"Error al actualizar el registro, consulte con el administrador. {ex.Message} ";
                throw;
            }
            return response;
        }

        public async Task<ApiResponse<SalesDtoQuery>> SalesPutIndicatorType(SalesPutIndicatorTypeCommand request, CancellationToken cancellationToken)
        {
            var response = new ApiResponse<SalesDtoQuery>();
            try
            {
                response.Data = _mapper.Map<SalesDtoQuery>(await _unitOfWork.SalesRepository.Put(_mapper.Map<Domain.Models.Sales.Sales>(request.SalesDtoQuery)));
            }
            catch (Exception ex)
            {
                response.Result = false;
                response.Message = $"Error al actualizar el registro, consulte con el administrador. {ex.Message} ";
                throw;
            }
            return response;
        }

        public async Task<ApiResponse<SalesDtoQuery>> SalesGetIndicatorTypeById(SalesGetIndicatorTypeByIdQuery request)
        {
            var response = new ApiResponse<SalesDtoQuery>();

            try
            {
                response.Data = _mapper.Map<SalesDtoQuery>(_unitOfWork.SalesRepository.Get()
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

        public async Task<ApiResponse<List<SalesDtoQuery>>> SalesGetAllIndicatorsType()
        {
            var response = new ApiResponse<List<SalesDtoQuery>>();
            try
            {

                response.Data = _mapper.Map<List<SalesDtoQuery>>(_unitOfWork.SalesRepository.Get().ToList());
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
