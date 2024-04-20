using Application.Common.Response;
using Application.DTOs.Store;
using Application.Interfaces.Store;
using MediatR;

namespace Application.Cqrs.IndicatorType.Commands
{
    public class PostIndicatorTypeCommand : IRequest<ApiResponse<StoreDto>>
    {
        public StoreDto StoreDto { get; set; }
    }
    public class PostIndicatorTypeCommandHandler : IRequestHandler<PostIndicatorTypeCommand, ApiResponse<StoreDto>>
    {
        private readonly IStore _indicatorType;
        public PostIndicatorTypeCommandHandler(IStore indicatorType)
        {
            _indicatorType = indicatorType;
        }
        public async Task<ApiResponse<StoreDto>> Handle(PostIndicatorTypeCommand request, CancellationToken cancellationToken)
        {
            return await _indicatorType.PostIndicatorType(request, cancellationToken);
        }
    }
}
