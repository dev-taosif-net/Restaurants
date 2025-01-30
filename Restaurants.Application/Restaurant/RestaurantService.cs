using Restaurants.Application.Restaurant.Dtos;
using Restaurants.Domain.Entites;
using Restaurants.Domain.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurants.Application.Restaurant;

internal class RestaurantService (IRestaurantRepository restaurantRepository) : IRestaurantService
{
    public async Task<IEnumerable<RestaurantDto?>> GetAllRestaurants()
    {
        var result = await restaurantRepository.GetAll();
        var data = result.Select(RestaurantDto.FromRestaurant).ToList();

        return data;


    }

    public async Task<RestaurantDto?> GetById(int id)
    {
        var result = await restaurantRepository.GetById(id);
        return RestaurantDto.FromRestaurant(result);
    }
}
