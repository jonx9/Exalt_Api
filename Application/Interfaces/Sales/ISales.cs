using Application.Common.Response;
using Application.Cqrs.IndicatorType.Commands;
using Application.Cqrs.IndicatorType.Querys;
using Application.Cqrs.Sales.Querys;
using Application.Cqrs.Sales.Commands;
using Application.DTOs.Sales;

namespace Application.Interfaces.Sales
{
    public interface ISales
    { 
        Task<ApiResponse<bool>> SalesDeleteIndicatorType(SalesDeleteIndicatorTypeCommand request);
        Task<ApiResponse<List<SalesDtoQuery>>> SalesGetIndicatorsType(SalesGetIndicatorTypeQuery request, CancellationToken cancellationToken);
        Task<ApiResponse<SalesDto>> SalesPostIndicatorType(SalesPostIndicatorTypeCommand request, CancellationToken cancellationToken);
        Task<ApiResponse<SalesDtoQuery>> SalesPutIndicatorType(SalesPutIndicatorTypeCommand request, CancellationToken cancellationToken);
        Task<ApiResponse<SalesDtoQuery>> SalesGetIndicatorTypeById(SalesGetIndicatorTypeByIdQuery request);
        Task<ApiResponse<List<SalesDtoQuery>>> SalesGetAllIndicatorsType();
    }
}