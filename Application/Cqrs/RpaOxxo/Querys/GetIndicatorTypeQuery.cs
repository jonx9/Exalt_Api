using Application.Common.Response;
using Application.DTOs.Store;
using Application.Interfaces.Store;
using MediatR;

namespace Application.Cqrs.IndicatorType.Querys
{
    public class GetIndicatorTypeQuery : IRequest<ApiResponse<List<StoreDtoQuery>>>
    {
        public string? Estado { get; set; }
        public string? ReportDate { get; set; }
    }
    public class GetIndicatorTypeQueryHandler : IRequestHandler<GetIndicatorTypeQuery, ApiResponse<List<StoreDtoQuery>>>
    {
        private readonly IStore _indicatorTypeService;
        public GetIndicatorTypeQueryHandler(IStore indicatorTypeService)
        {
            _indicatorTypeService = indicatorTypeService;
        }
        public async Task<ApiResponse<List<StoreDtoQuery>>> Handle(GetIndicatorTypeQuery request, CancellationToken cancellationToken)
        {
            return await _indicatorTypeService.GetIndicatorsType(request, cancellationToken);
        }
    }
}
