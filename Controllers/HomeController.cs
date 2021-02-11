using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Nefis_413Assignment_4.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Nefis_413Assignment_4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<string> restaurantList = new List<string>(); //angle brackets indicate type, followed by name. first part is declaration of variable, right side is instantiation

            foreach (Restaurants r in Restaurants.GetRestaurants())
            {
                if (r.WebLink == "Coming soon") //remove hyperlink if it says coming soon
                {
                    restaurantList.Add(string.Format("Rank: #{0} <br/> Restaurant: {1} <br/> Favorite Dish: {2} <br/> Address: {3} <br/> Phone: {4} <br/> Website: {5}", r.RestaurantRanking, r.RestaurantName, r.FavDish, r.Address, r.Phone, r.WebLink));
                }
                else
                {
                    restaurantList.Add(string.Format("Rank: #{0} <br/> Restaurant: {1} <br/> Favorite Dish: {2} <br/> Address: {3} <br/> Phone: {4} <br/> Website: <a target=\"_blank\" href=\"{5}\">{5}</a>", r.RestaurantRanking, r.RestaurantName, r.FavDish, r.Address, r.Phone, r.WebLink)); //acts based off of positions
                }
            }

            return View(restaurantList); //taking bandlist and passing it to view
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SuggestRestaurant()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SuggestRestaurant(AddRestaurant oNewRestaurant)
        {
            

            if (ModelState.IsValid) //check the field inputs if they are valid
            {
                Repository.AddResponse(oNewRestaurant);
                Response.Redirect("SuggestRestaurant");
                //Response.Redirect("SuggestRestaurant"); // if submission is taken, this will take info and show the add movie page with fields cleared
            }
            return View();
        }
        public IActionResult ViewSuggestions()
        {
            return View(Repository.Responses);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
