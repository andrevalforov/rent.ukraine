using Microsoft.AspNetCore.Mvc;
using RentCourse.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentCourse.Components
{
    public class Location:ViewComponent
    {
        private readonly ILocations _location;
        public Location(ILocations location)
        {
            _location = location;
        }

        public IViewComponentResult Invoke()
        {
            var location = _location.Locations;
            return View(location);
        }
    }
}
