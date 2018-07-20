using OdeToFood.Models;
using System.ComponentModel.DataAnnotations;

namespace OdeToFood.ViewModel
{
    public class RestaurantEditModel
    {
        public CuisineType Cuisine { get; set; }

        [Required, MaxLength(80)]
        public string Name { get; set; }

    }
}
