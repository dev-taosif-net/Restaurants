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
    public async Task<IEnumerable<Restaurants.Domain.Entites.Restaurant>> GetAllRestaurants()
    {
        return await restaurantRepository.GetAll();

    }

    public async Task<Domain.Entites.Restaurant?> GetById(int id)
    {
        return await restaurantRepository.GetById(id);
    }
}
