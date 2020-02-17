using RentCourse.Data.EFContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RentCourse.Data.Interfaces;
using RentCourse.Data.Models;

namespace RentCourse.Data.Repository
{
    public class CategoryRepository:ICategories
    {
        private readonly EFDbContext _context;
        public CategoryRepository(EFDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Category> Categories => _context.Categories;
    }
}
