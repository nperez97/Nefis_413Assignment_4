using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Nefis_413Assignment_4.Models
{
    public class Restaurants
    {

        //constructor
        public Restaurants(int rank)
        {
            RestaurantRanking = rank;
        }

        [Required]
        public int? RestaurantRanking { get; } = 999;
        [Required]
        public string RestaurantName { get; set; }
        [Required]
        public string Address { get; set; }
#nullable enable
        public string? FavDish { get; set; } = "It's all Tasty!";
#nullable disable
        //[RegularExpression(@"^\(\d{3}\)\s\d{3}-\d{4}")]
        public string? Phone { get; set; }
#nullable enable
        public string? WebLink { get; set; } = "Coming soon";
#nullable disable

        public static Restaurants[] GetRestaurants()
        {
            Restaurants r1 = new Restaurants(1)
            {
                RestaurantName = "Chick-fil-A",
                FavDish = "Spicy Deluxe Sandwich",
                Address = "484 Bulldog Ln, Provo, UT 84604",
                Phone = "(801) 224-0958",
                WebLink = "https://www.chick-fil-a.com/"

            };

            Restaurants r2 = new Restaurants(2)
            {

                RestaurantName = "Red Robin",
                //FavDish = "Haystack Tavern Double",
                Address = "1200 Towne Centre Blvd, Provo, UT 84601",
                Phone = "(801) 852-8093",
                WebLink = "https://www.redrobin.com/"
            };

            Restaurants r3 = new Restaurants(3)
            {

                RestaurantName = "Cafe Rio",
                FavDish = "Sweet Pork Burrito",
                Address = "2244 N University Pkwy",
                Phone = "(801) 375-5133",
                WebLink = "https://www.caferio.com/"
            };

            Restaurants r4 = new Restaurants(4)
            {

                RestaurantName = "Leatherby's Family Creamery",
                FavDish = "Strawberry Short Cake Icecream",
                Address = "304 E University Pkwy, Orem, UT 84058",
                Phone = "(385) 223-8140",
                WebLink = "https://www.leatherbys.com/"
            };

            Restaurants r5 = new Restaurants(5)
            {
                RestaurantName = "Panda Express",
                FavDish = "Orange Chicken",
                Address = "1240 N University Ave, Provo, UT 84604",
                Phone = "(801) 818-0111",
                //WebLink = //"https://www.pandaexpress.com/"
            };


            return new Restaurants[] { r1, r2, r3, r4, r5 };
        }
    }
}
