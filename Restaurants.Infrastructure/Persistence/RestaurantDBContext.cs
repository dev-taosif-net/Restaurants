using Microsoft.EntityFrameworkCore;
using Restaurants.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurants.Infrastructure.Persistence;

public class RestaurantDBContext(DbContextOptions<RestaurantDBContext> options) : DbContext (options)
{
    public DbSet<Restaurant> Restaurants { get; set; }
    public DbSet<Dish> Dishes { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Restaurant>()
            .OwnsOne(r => r.Address);

        modelBuilder.Entity<Restaurant>()
            .HasMany(r => r.Dishes)
            .WithOne()
            .HasForeignKey(d => d.RestaurantId);

        //modelBuilder.Entity<User>()
        //    .HasMany(o => o.OwnedRestaurants)
        //    .WithOne(r => r.Owner)
        //    .HasForeignKey(r => r.OwnerId);
    }

}


