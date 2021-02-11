using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Nefis_413Assignment_4.Models
{
    public class AddRestaurant
    {
#nullable enable
        public string? Name { get; set; }
#nullable disable
        [Required]
        public string RestaurantName { get; set; }
        [Required]
#nullable enable
        public string? FavDish { get; set; } = "It's all Tasty!";
        [RegularExpression(@"^\(\d{3}\)\s\d{3}-\d{4}", ErrorMessage = "Please enter phone in this format: (XXX) XXX-XXXX")]
        public string? Phone { get; set; }
#nullable disable
    }
}
