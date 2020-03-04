using RentCourse.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentCourse.ViewModels
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> GetProducts { get; set; }
        public string ProductCategory { get; set; }
        public string ProductType { get; set; }
    }
}
