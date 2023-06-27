using AutoMapper;
using Market_Place.Areas.Identity.Data;
using App.Domain.Core.DTOs;
using App.Domain.Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Identity.Client;

namespace Market_Place.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<LoginViewModel, AdminDto>();
            CreateMap<RegisterViewModel, AdminDto>();

            CreateMap<Admin, AdminDto>();
            CreateMap<Customer, CustomerDto>();
            CreateMap<SalesMan, SalesManDto>()
                .ForMember(dest => dest.BoothId, opt => opt.MapFrom(e => e.Booth.Id));
            CreateMap<Product, ProductDto>();
            CreateMap<Bid, BidDto>();

            CreateMap<Admin, AppUserDto>()
                .ForMember(dest => dest.BoothId, opt => opt.AllowNull());
            CreateMap<Customer, AppUserDto>()
                .ForMember(dest => dest.BoothId, opt => opt.AllowNull());
            CreateMap<SalesMan, AppUserDto>()
                .ForMember(dest => dest.BoothId, opt => opt.MapFrom(e => e.Id));

            CreateMap<IdentityUser<int>, AdminDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(e => e.Id))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(e => e.Email))
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(e => e.UserName));
            
            CreateMap<IdentityUser<int>, CustomerDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(e => e.Id))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(e => e.Email))
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(e => e.UserName));
            
            CreateMap<IdentityUser<int>, SalesManDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(e => e.Id))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(e => e.Email))
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(e => e.UserName));

            CreateMap<Admin, AdminDto>().ReverseMap();
            CreateMap<Customer, CustomerDto>().ReverseMap();
            CreateMap<SalesMan, SalesManDto>().ReverseMap();
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<Bid, BidDto>().ReverseMap();

        }

    }
}
