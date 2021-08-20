using RentCourse.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentCourse.Data.Interfaces
{
    public interface IProducts
    {
        IEnumerable<Product> GetAllProducts { get; }
        IEnumerable<Product> GetAvProducts { get; }
        IEnumerable<Product> GetProductsByCategory(int CategoryId);
        IEnumerable<Product> GetProductsByType(int TypeId);
        IEnumerable<Product> GetProducts(string type, string category, string location, string sort, string? search, double? minprice, double? maxprice);
        Product GetProduct(int Id);
    }
}
