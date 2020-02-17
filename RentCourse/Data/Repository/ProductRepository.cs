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

        
    }
}
