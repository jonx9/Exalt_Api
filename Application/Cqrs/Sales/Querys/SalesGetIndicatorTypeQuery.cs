using Application.Common.Response;
using Application.DTOs.Store;
using Application.DTOs.Sales;
using Application.Interfaces.Store;
using Application.Interfaces.Sales;
using MediatR;

namespace Application.Cqrs.IndicatorType.Querys
{
    public class SalesGetIndicatorTypeQuery : IRequest<ApiResponse<List<SalesDtoQuery>>>
    {
        public string? Estado { get; set; }
        public string? ReportDate { get; set; }
    }
    public class SalesGetIndicatorTypeQueryHandler : IRequestHandler<SalesGetIndicatorTypeQuery, ApiResponse<List<SalesDtoQuery>>>
    {
        private readonly ISales _indicatorTypeService;
        public SalesGetIndicatorTypeQueryHandler(ISales indicatorTypeService)
        {
            _indicatorTypeService = indicatorTypeService;
        }
        public async Task<ApiResponse<List<SalesDtoQuery>>> Handle(SalesGetIndicatorTypeQuery request, CancellationToken cancellationToken)
        {
            return await _indicatorTypeService.SalesGetIndicatorsType(request, cancellationToken);
        }
    }
}
