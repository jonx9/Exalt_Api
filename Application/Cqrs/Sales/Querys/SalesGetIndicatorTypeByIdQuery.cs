using Application.Common.Response;
using Application.Cqrs.IndicatorType.Querys;
using Application.DTOs.Store;
using Application.DTOs.Sales;
using Application.Interfaces.Store;
using Application.Interfaces.Sales;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Cqrs.Sales.Querys
{
    public class SalesGetIndicatorTypeByIdQuery : IRequest<ApiResponse<SalesDtoQuery>>
    {
        public Guid Id { get; set; }
    }
    public class SalesGetIndicatorTypeByIdQueryHandler : IRequestHandler<SalesGetIndicatorTypeByIdQuery, ApiResponse<SalesDtoQuery>>
    {
        private readonly ISales _indicatorTypeService;
        public SalesGetIndicatorTypeByIdQueryHandler(ISales indicatorTypeService)
        {
            _indicatorTypeService = indicatorTypeService;
        }
        public async Task<ApiResponse<SalesDtoQuery>> Handle(SalesGetIndicatorTypeByIdQuery request, CancellationToken cancellationToken)
        {
            return await _indicatorTypeService.SalesGetIndicatorTypeById(request);
        }
    }
}
