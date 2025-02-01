using AutoMapper;
using Restaurants.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurants.Application.Restaurant.Dtos;

public class RestaurantProfile : Profile
{
    public RestaurantProfile()
    {
        CreateMap<Domain.Entites.Restaurant, RestaurantDto>()
            .ForMember(d=>d.Street , src => src.MapFrom(x=>x.Address == null ? null : x.Address.Street))
            .ForMember(d => d.City, src => src.MapFrom(x => x.Address == null ? null : x.Address.City))
            .ForMember(d => d.PostalCode, src => src.MapFrom(x => x.Address == null ? null : x.Address.PostalCode))
            .ForMember(d => d.Dishes, src => src.MapFrom(x => x.Dishes));
    }
}
