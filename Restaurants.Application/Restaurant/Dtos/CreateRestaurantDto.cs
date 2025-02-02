using Restaurants.Application.Dish.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurants.Application.Restaurant.Dtos;

public class CreateRestaurantDto
{
    public Guid Code { get; set; } = Guid.NewGuid();
    public required string Name { get; set; } = default!;
    public required string Description { get; set; } = default!;
    public required string Category { get; set; } = default!;
    public bool HasDelivery { get; set; } = false;
    public string? City { get; set; }
    public string? Street { get; set; }
    public string? PostalCode { get; set; }
    //public List<DishDto> Dishes { get; set; } = [];
}
