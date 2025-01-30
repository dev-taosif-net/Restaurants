using Restaurants.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurants.Domain.Entites;

namespace Restaurants.Application.Restaurant;

public interface IRestaurantService
{
    Task<IEnumerable<Domain.Entites.Restaurant>> GetAllRestaurants();
    Task<Domain.Entites.Restaurant?> GetById(int id);

}
