using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nefis_413Assignment_4.Models
{
    public static class Repository
    {
        private static List<AddRestaurant> responses = new List<AddRestaurant>();
        public static IEnumerable<AddRestaurant> Responses => responses;
        public static void AddResponse(AddRestaurant response)
        {
            responses.Add(response);
        }
    }
}
