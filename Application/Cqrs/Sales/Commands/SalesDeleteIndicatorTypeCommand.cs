using Application.Common.Response;
using Application.Interfaces.Store;
using Application.Interfaces.Sales;
using MediatR;

namespace Application.Cqrs.Sales.Commands
{
    public class SalesDeleteIndicatorTypeCommand : IRequest<ApiResponse<bool>>
    {
        public Guid Id { get; set; }
    }
    public class SalesDeleteIndicatorTypeCommandHandler : IRequestHandler<SalesDeleteIndicatorTypeCommand, ApiResponse<bool>>
    {
        private readonly ISales _IndicatorTypeService;
        public SalesDeleteIndicatorTypeCommandHandler(ISales IndicatorTypeService)
        {
            _IndicatorTypeService = IndicatorTypeService;
        }

        public async Task<ApiResponse<bool>> Handle(SalesDeleteIndicatorTypeCommand request, CancellationToken cancellationToken)
        {
            return await _IndicatorTypeService.SalesDeleteIndicatorType(request);
        }
    }
}
