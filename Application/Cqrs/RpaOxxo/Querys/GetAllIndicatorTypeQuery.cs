using Application.Common.Response;
using Application.DTOs.Store;
using Application.Interfaces.Store;
using MediatR;

namespace Application.Cqrs.IndicatorType.Querys
{
    public class GetAllIndicatorTypeQuery : IRequest<ApiResponse<List<StoreDtoQuery>>>
    {

    }
    public class GetAllIndicatorTypeQueryHandler : IRequestHandler<GetAllIndicatorTypeQuery, ApiResponse<List<StoreDtoQuery>>>
    {
        private readonly IStore _indicatorTypeService;
        public GetAllIndicatorTypeQueryHandler(IStore indicatorTypeService)
        {
            _indicatorTypeService = indicatorTypeService;
        }
        public async Task<ApiResponse<List<StoreDtoQuery>>> Handle(GetAllIndicatorTypeQuery request, CancellationToken cancellationToken)
        {
            return await _indicatorTypeService.GetAllIndicatorsType();
        }
    }
}
