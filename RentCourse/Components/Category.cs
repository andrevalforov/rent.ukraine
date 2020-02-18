using Microsoft.AspNetCore.Mvc;
using RentCourse.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentCourse.Components
{
    public class Category : ViewComponent
    {
        private readonly ICategories _category;
        public Category(ICategories category)
        {
            _category = category;
        }

        public IViewComponentResult Invoke()
        {
            var category = _category.Categories;
            return View(category);
        }
    }
}
