using Application.DTOs.Role;
using Application.DTOs.Sales;
using Application.DTOs.Store;
using Application.DTOs.User;
using AutoMapper;
using Domain.Models.Role;
using Domain.Models.Store;
using Domain.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.AutoMapper
{
    public class ViewModelToDomainProfile : Profile
    {
        public ViewModelToDomainProfile()
        {
            CreateMap<UserDto, User>();
            CreateMap<UserPostDto, User>();
            CreateMap<RoleDto, Role>();
            CreateMap<StoreDto, Store>();
            CreateMap<StoreDtoQuery, Store>();
            CreateMap<SalesDto, Store>();
            CreateMap<SalesDtoQuery, Store>();
        }
    }
}
