using Restaurants.Application.Dish.Dtos;
using Restaurants.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurants.Application.Restaurant.Dtos;
public class RestaurantDto
{
    public int Id { get; set; }
    public Guid Code { get; set; }
    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;
    public string Category { get; set; } = default!;
    public bool HasDelivery { get; set; } = false;
    public string? City { get; set; }
    public string? Street { get; set; }
    public string? PostalCode { get; set; }
    public List<DishDto> Dishes { get; set; } = [];

    public static RestaurantDto? FromRestaurant(Restaurants.Domain.Entites.Restaurant? restaurant)
    {
        if (restaurant == null) return null;

        return new RestaurantDto
        {
            Id = restaurant.Id,
            Code = restaurant.Code,
            Name = restaurant.Name,
            Description = restaurant.Description,
            Category = restaurant.Category,
            HasDelivery = restaurant.HasDelivery,
            City = restaurant.Address?.City,
            Street = restaurant.Address?.Street,
            PostalCode = restaurant.Address?.PostalCode,
            Dishes = restaurant.Dishes.Select(DishDto.FromDish).ToList()
        };
    }

}
