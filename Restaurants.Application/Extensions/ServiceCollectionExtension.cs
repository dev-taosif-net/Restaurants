using Microsoft.Extensions.DependencyInjection;
using Restaurants.Application.Restaurant;
using Restaurants.Domain.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Restaurants.Application.Extensions;

public static class ServiceCollectionExtension
{
    public static void AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IRestaurantService, RestaurantService>();
        services.AddAutoMapper(typeof(ServiceCollectionExtension).Assembly);
    }
}
