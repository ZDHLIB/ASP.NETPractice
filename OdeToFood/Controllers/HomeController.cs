using Microsoft.AspNetCore.Mvc;
using OdeToFood.Models;
using OdeToFood.Services;
using OdeToFood.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        private IRestaurantData _resturantData;
        private IGreeter _greeter;

        public HomeController(IRestaurantData restaurantData, IGreeter greeter) {
            _resturantData = restaurantData;
            _greeter = greeter;
        }
        public IActionResult Index() {
            //var model = new Restaurant { Id = 1, Name = "Zac" };
            //return new ObjectResult(model);
            //var model = _resturantData.GetAll();
            var model = new HomeIndexViewModel();
            model.Restaurants = _resturantData.GetAll();
            model.CurrentMessage = _greeter.GetMessage();
            return View(model);
        }

        public IActionResult Details(int id) {
            var model = _resturantData.Get(id);
            if (model == null) {
                //return NotFound();
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }
    }
}
