﻿using AutoMapper;
using Restaurants.Application.Restaurant.Dtos;
using Restaurants.Domain.Entites;
using Restaurants.Domain.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurants.Application.Restaurant;

internal class RestaurantService (IRestaurantRepository restaurantRepository , IMapper mapper) : IRestaurantService
{
    public async Task<int> CreateRestaurant(CreateRestaurantDto obj)
    {
        var data = mapper.Map<Domain.Entites.Restaurant>(obj);
        var res = await restaurantRepository.Create(data);
        return res;
    }

    public async Task<IEnumerable<RestaurantDto?>> GetAllRestaurants()
    {
        var result = await restaurantRepository.GetAll();
        var data = mapper.Map<IEnumerable<RestaurantDto?>>(result);
        //var data = result.Select(RestaurantDto.FromRestaurant).ToList();

        return data;
    }

    public async Task<RestaurantDto?> GetById(int id)
    {
        var result = await restaurantRepository.GetById(id);
        //return RestaurantDto.FromRestaurant(result);

        var data = mapper.Map<RestaurantDto?>(result);

        return data;
    }
}
