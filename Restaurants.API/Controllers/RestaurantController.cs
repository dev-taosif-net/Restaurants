using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurants.Application.Restaurant;

namespace Restaurants.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RestaurantController (IRestaurantService restaurantService) : ControllerBase
{
    [HttpGet]
    [Route("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var restaurants = await restaurantService.GetAllRestaurants();
        return Ok(restaurants);
    }
    [HttpGet]
    [Route("Get")]
    public async Task<IActionResult> Get(int id)
    {
        var restaurant = await restaurantService.GetById(id);

        if (restaurant is null)
        {
            return NotFound();
        }
        return Ok(restaurant);
    }
}
