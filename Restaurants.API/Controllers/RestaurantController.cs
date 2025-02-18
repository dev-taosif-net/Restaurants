﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurants.Application.Restaurant;
using Restaurants.Application.Restaurant.Dtos;

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

    [HttpPost]
    [Route("CreateRestaurant")]
    public async Task<IActionResult> CreateRestaurant(CreateRestaurantDto obj)
    {
        if(!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var id = await restaurantService.CreateRestaurant(obj);
        return Ok(id);
    }


}
