using Microsoft.EntityFrameworkCore;
using Restaurants.Domain.Entites;
using Restaurants.Domain.IRepository;
using Restaurants.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurants.Infrastructure.Repository;

internal class RestaurantRepository(RestaurantDBContext dbContext) : IRestaurantRepository
{
    public async Task<IEnumerable<Restaurant>> GetAll()
    {
        return await dbContext.Restaurants
            .Include(x=>x.Dishes)
            .ToListAsync();
    }

    public async Task<Restaurant?> GetById(int id)
    {
        return await dbContext.Restaurants.FindAsync(id);
    }
}
