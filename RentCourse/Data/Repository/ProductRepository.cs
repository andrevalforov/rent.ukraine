using Microsoft.EntityFrameworkCore;
using RentCourse.Data.EFContext;
using RentCourse.Data.Interfaces;
using RentCourse.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentCourse.Data.Repository
{
    public class ProductRepository:IProducts
    {
        private readonly EFDbContext _context;
        public ProductRepository(EFDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Product> GetAllProducts => _context.Products.Include(x => x.Category);

        public IEnumerable<Product> GetAvProducts => _context.Products.Where(x => x.Available == true)
            .Include(x => x.Category);

        public IEnumerable<Product> GetProductsByCategory(int Id) => _context.Products.Where(x=>x.CategoryId==Id);

        public IEnumerable<Product> GetProductsByType(int Id) => _context.Products.Where(x=>x.Category.TypeId==Id);

        public Product GetProduct(int Id) => _context.Products.FirstOrDefault(x => x.Id == Id);

        public IEnumerable<Product> GetProducts(string type, string category, string location, string sort, string? search, double? minprice, double? maxprice)
        {
            IEnumerable<Product> products = null;
            if (category == "Усі речі" || category == "Уся нерухомість" || category == "Увесь транспорт")
            {
                products = GetAvProducts;
            }
            else
            {
                products = GetAvProducts.Where(x => x.CategoryId == _context.Categories.FirstOrDefault(t => t.Name == category).Id);
            }

            if (location != "Уся Україна")
            {
                products = products.Where(x => x.LocationId == _context.Locations.FirstOrDefault(t => t.City == location).Id);
            }

            if (search != null)
            {
                products = products.Where(x => x.Title.ToLower().Contains(search.ToLower()));
            }

            if (minprice == 0 && maxprice == 0)
            { }
            else 
            { 
                if (minprice <= maxprice)
                {
                    products = products.Where(x => x.Price >= minprice && x.Price <= maxprice);
                }
                else
                {
                    products = products.Where(x => x.Price >= minprice);
                }
            }

            if (sort == "new")
            {
                products.OrderBy(x => x.DateOfPublication);
            }
            else if (sort == "min")
            {
                products.OrderBy(x => x.Price);
            }
            else if (sort == "max")
            {
                products.OrderByDescending(x => x.Price);
            }
            
            return products;
        }
    }
}
