using Application.Common.Response;
using Application.Interfaces.Store;
using MediatR;

namespace Application.Cqrs.User.Commands
{
    public class DeleteIndicatorTypeCommand : IRequest<ApiResponse<bool>>
    {
        public Guid Id { get; set; }
    }
    public class DeleteIndicatorTypeCommandHandler : IRequestHandler<DeleteIndicatorTypeCommand, ApiResponse<bool>>
    {
        private readonly IStore _IndicatorTypeService;
        public DeleteIndicatorTypeCommandHandler(IStore IndicatorTypeService)
        {
            _IndicatorTypeService = IndicatorTypeService;
        }

        public async Task<ApiResponse<bool>> Handle(DeleteIndicatorTypeCommand request, CancellationToken cancellationToken)
        {
            return await _IndicatorTypeService.DeleteIndicatorType(request);
        }
    }
}
