using Application.Common.Response;
using Application.DTOs.Store;
using Application.Interfaces.Store;
using MediatR;

namespace Application.Cqrs.IndicatorType.Commands
{
    public class PutIndicatorTypeCommand : IRequest<ApiResponse<StoreDtoQuery>>
    {
        public StoreDtoQuery StoreDtoQuery { get; set; }
    }
    public class PutIndicatorTypeCommandsHandler : IRequestHandler<PutIndicatorTypeCommand, ApiResponse<StoreDtoQuery>>
    {
        private readonly IStore _indicatorType;
        public PutIndicatorTypeCommandsHandler(IStore indicatorType)
        {
            _indicatorType = indicatorType;
        }
        public async Task<ApiResponse<StoreDtoQuery>> Handle(PutIndicatorTypeCommand request, CancellationToken cancellationToken)
        {
            return await _indicatorType.PutIndicatorType(request, cancellationToken);
        }
    }
}
