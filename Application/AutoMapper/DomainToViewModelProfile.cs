using Application.DTOs.Role;
using Application.DTOs.Sales;
using Application.DTOs.Store;
using Application.DTOs.User;
using AutoMapper;
using Domain.Models.Role;
using Domain.Models.Sales;
using Domain.Models.Store;
using Domain.Models.User;

namespace Application.AutoMapper
{
    public class DomainToViewModelProfile : Profile
    {
        public DomainToViewModelProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<User, UserPostDto>();
            CreateMap<Role, RoleDto>();
            CreateMap<Store, StoreDto>();
            CreateMap<Store, StoreDtoQuery>();
            CreateMap<Sales, SalesDto>();
            CreateMap<Sales, SalesDtoQuery>();

        }
    }
}
