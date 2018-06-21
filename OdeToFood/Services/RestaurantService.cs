using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Services
{
    public class RestaurantService : IRestaurantData
    {
        public RestaurantService() { 
            _restaurants = new List<Restaurant> {
                new Restaurant {Id=1, Name="R1"},
                new Restaurant {Id=2, Name="R2"},
                new Restaurant {Id=3, Name="R3"}
            };
        }

        public IEnumerable<Restaurant> GetAll() {
            return _restaurants.OrderBy(r => r.Name);
        }

        public Restaurant Get(int id) {
            return _restaurants.FirstOrDefault(r => r.Id==id);
        }

        List<Restaurant> _restaurants;
    }

    
}
