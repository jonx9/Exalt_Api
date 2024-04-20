using Application.Common.Response;
using Application.DTOs.Store;
using Application.DTOs.Sales;
using Application.Interfaces.Sales;
using Application.Interfaces.Sales;
using MediatR;

namespace Application.Cqrs.IndicatorType.Commands
{
    public class SalesPutIndicatorTypeCommand : IRequest<ApiResponse<SalesDtoQuery>>
    {
        public SalesDtoQuery SalesDtoQuery { get; set; }
    }
    public class SalesPutIndicatorTypeCommandsHandler : IRequestHandler<SalesPutIndicatorTypeCommand, ApiResponse<SalesDtoQuery>>
    {
        private readonly ISales _indicatorType;
        public SalesPutIndicatorTypeCommandsHandler(ISales indicatorType)
        {
            _indicatorType = indicatorType;
        }
        public async Task<ApiResponse<SalesDtoQuery>> Handle(SalesPutIndicatorTypeCommand request, CancellationToken cancellationToken)
        {
            return await _indicatorType.SalesPutIndicatorType(request, cancellationToken);
        }
    }
}
