using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurants.Application.Dish.Dtos;

public class DishProfile : Profile
{
    public DishProfile()
    {
        CreateMap<Restaurants.Domain.Entites.Dish, DishDto>();
    }
}
