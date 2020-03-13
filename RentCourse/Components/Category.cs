using Microsoft.AspNetCore.Mvc;
using RentCourse.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentCourse.Components
{
    public class Mod
    {
        public IEnumerable<Data.Models.Category> Categories { get; set; }
        public IEnumerable<Data.Models.Location> Locations { get; set; }

        public Mod(IEnumerable<Data.Models.Category> categories, IEnumerable<Data.Models.Location> locations)
        {
            Categories = categories;
            Locations = locations;
        }
    }
    public class Category : ViewComponent
    {
        private readonly ICategories _category;
        private readonly ILocations _location;
        public Category(ICategories category, ILocations location)
        {
            _category = category;
            _location = location;
        }

        public IViewComponentResult Invoke()
        {   
            var category = _category.Categories;
            var location = _location.Locations;
            Mod mod = new Mod(category, location);
            return View(mod);
        }
    }
}
