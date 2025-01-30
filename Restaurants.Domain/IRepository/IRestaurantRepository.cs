using Restaurants.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurants.Domain.IRepository;

public interface IRestaurantRepository
{
    Task<IEnumerable<Restaurant>> GetAll();
    Task<Restaurant?> GetById(int id);

}
