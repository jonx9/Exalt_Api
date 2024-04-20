using Application.Common.Response;
using Application.DTOs.Sales;
using Application.Interfaces.Sales;
using MediatR;

namespace Application.Cqrs.IndicatorType.Commands
{
    public class SalesPostIndicatorTypeCommand : IRequest<ApiResponse<SalesDto>>
    {
        public SalesDto SalesDto { get; set; }
    }
    public class SalesPostIndicatorTypeCommandHandler : IRequestHandler<SalesPostIndicatorTypeCommand, ApiResponse<SalesDto>>
    {
        private readonly ISales _indicatorType;
        public SalesPostIndicatorTypeCommandHandler(ISales indicatorType)
        {
            _indicatorType = indicatorType;
        }
        public async Task<ApiResponse<SalesDto>> Handle(SalesPostIndicatorTypeCommand request, CancellationToken cancellationToken)
        {
            return await _indicatorType.SalesPostIndicatorType(request, cancellationToken);
        }
    }
}
