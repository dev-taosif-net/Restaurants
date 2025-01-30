using Restaurants.Application.Restaurant.Dtos;
using Restaurants.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurants.Application.Restaurant;

public interface IRestaurantService
{
    Task<IEnumerable<RestaurantDto?>> GetAllRestaurants();
    Task<RestaurantDto?> GetById(int id);

}
