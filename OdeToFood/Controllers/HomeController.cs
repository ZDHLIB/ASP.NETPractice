using Microsoft.AspNetCore.Mvc;
using OdeToFood.Models;
using OdeToFood.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        private IResturantData _resturantData;
        public HomeController(IResturantData restaurantData) {
            _resturantData = restaurantData;
        }
        public IActionResult Index() {
            //var model = new Restaurant { Id = 1, Name = "Zac" };
            //return new ObjectResult(model);
            var model = _resturantData.GetAll();
            return View(model);
        }
    }
}
