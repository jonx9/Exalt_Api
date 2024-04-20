using Application.Common.Response;
using Application.DTOs.Sales;
using Application.Interfaces.Store;
using Application.Interfaces.Sales;
using MediatR;

namespace Application.Cqrs.IndicatorType.Querys
{
    public class SalesGetAllIndicatorTypeQuery : IRequest<ApiResponse<List<SalesDtoQuery>>>
    {

    }
    public class SalesGetAllIndicatorTypeQueryHandler : IRequestHandler<SalesGetAllIndicatorTypeQuery, ApiResponse<List<SalesDtoQuery>>>
    {
        private readonly ISales _indicatorTypeService;
        public SalesGetAllIndicatorTypeQueryHandler(ISales indicatorTypeService)
        {
            _indicatorTypeService = indicatorTypeService;
        }
        public async Task<ApiResponse<List<SalesDtoQuery>>> Handle(SalesGetAllIndicatorTypeQuery request, CancellationToken cancellationToken)
        {
            return await _indicatorTypeService.SalesGetAllIndicatorsType();
        }
    }
}
