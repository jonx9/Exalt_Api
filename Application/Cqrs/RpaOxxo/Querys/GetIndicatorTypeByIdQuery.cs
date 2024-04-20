using Application.Common.Response;
using Application.Cqrs.IndicatorType.Querys;
using Application.DTOs.Store;
using Application.Interfaces.Store;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Cqrs.Store.Querys
{
    public class GetIndicatorTypeByIdQuery : IRequest<ApiResponse<StoreDtoQuery>>
    {
        public Guid Id { get; set; }
    }
    public class GetIndicatorTypeByIdQueryHandler : IRequestHandler<GetIndicatorTypeByIdQuery, ApiResponse<StoreDtoQuery>>
    {
        private readonly IStore _indicatorTypeService;
        public GetIndicatorTypeByIdQueryHandler(IStore indicatorTypeService)
        {
            _indicatorTypeService = indicatorTypeService;
        }
        public async Task<ApiResponse<StoreDtoQuery>> Handle(GetIndicatorTypeByIdQuery request, CancellationToken cancellationToken)
        {
            return await _indicatorTypeService.GetIndicatorTypeById(request);
        }
    }
}
