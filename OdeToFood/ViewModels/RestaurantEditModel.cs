using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.ViewModels
{
    public class RestaurantEditModel
    {
        public string Name { get; set; }
        public EnumCuisineType Cuisine { get; set; }
    }
}
