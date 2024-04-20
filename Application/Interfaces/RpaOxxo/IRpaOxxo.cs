using Application.Common.Response;
using Application.Cqrs.IndicatorType.Commands;
using Application.Cqrs.IndicatorType.Querys;
using Application.Cqrs.Store.Querys;
using Application.Cqrs.User.Commands;
using Application.DTOs.Store;

namespace Application.Interfaces.Store
{
    public interface IStore
    {
        Task<ApiResponse<bool>> DeleteIndicatorType(DeleteIndicatorTypeCommand request);
        Task<ApiResponse<List<StoreDtoQuery>>> GetIndicatorsType(GetIndicatorTypeQuery request, CancellationToken cancellationToken);
        Task<ApiResponse<StoreDto>> PostIndicatorType(PostIndicatorTypeCommand request, CancellationToken cancellationToken);
        Task<ApiResponse<StoreDtoQuery>> PutIndicatorType(PutIndicatorTypeCommand request, CancellationToken cancellationToken);
        Task<ApiResponse<StoreDtoQuery>> GetIndicatorTypeById(GetIndicatorTypeByIdQuery request);
        Task<ApiResponse<List<StoreDtoQuery>>> GetAllIndicatorsType();
    }
}