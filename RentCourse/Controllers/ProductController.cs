using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RentCourse.Data.Interfaces;
using RentCourse.Data.Models;
using RentCourse.ViewModels;

namespace RentCourse.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProducts _products;
        private readonly ICategories _category;
        private readonly ITypes _type;

        public ProductController(IProducts products, ICategories category,ITypes type)
        {
            _products = products;
            _category = category;
            _type = type;
        }
        //[Authorize(Roles = "User")]
        [Route("Home/MainCars")]
        [Route("Home/MainCars/{category}")]
        [Route("Home/MainRealEstate")]
        [Route("Home/MainRealEstate/{category}")]
        [Route("Home/MainThings")]
        [Route("Home/MainThings/{category}")]
        public ViewResult ListProducts(string category)
        {
            IEnumerable<Product> products = null;
            string productCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                products = _products.GetAllProducts.OrderBy(i => i.Id);
            }
            else
            {
                products = _products.GetAllProducts
                    .Where(x => x.Category.Name.ToLower() == category.ToLower());
                
                productCategory = category;
            }

            var productObj = new ProductListViewModel
            {
                GetProducts = products,
                ProductCategory = productCategory
            };

            return View(productObj);

        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(AddProductViewModel model)
        {
            if (ModelState.IsValid)
            {
                Product product = new Product
                {
                    Title = model.Title,
                    Description = model.Description,
                    CategoryId = model.CategotyId,
                    Price = model.Price,
                    Available = true,
                    DateOfPublication = DateTime.Now,
                    Location = model.Location,

                };
            }

            return View(model);
        }
    }
}