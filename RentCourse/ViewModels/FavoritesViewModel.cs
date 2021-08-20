using RentCourse.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentCourse.ViewModels
{
    public class FavoritesViewModel
    {
        public IEnumerable<Product> Products { get; set; }
    }
}
