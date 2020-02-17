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
        [Authorize(Roles = "User")]
        [Route("Product/ListProducts")]
        [Route("Product/ListProducts/{category}")]
        public ViewResult ListCars(string category)
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

                //if (string.Equals("Benzine", category, StringComparison.OrdinalIgnoreCase))
                //{
                //    cars = _cars.GetCars.Where(x => x.Category.Name.Equals("Benzine"))
                //        .OrderBy(i => i.Id);
                //}
                //else if (string.Equals("Diesel", category, StringComparison.OrdinalIgnoreCase))
                //{
                //    cars = _cars.GetCars.Where(x => x.Category.Name.Equals("Diesel"))
                //        .OrderBy(i => i.Id);
                //}
                //else
                //{
                //    cars = _cars.GetCars.Where(x => x.Category.Name.Equals("Electricity"))
                //        .OrderBy(i => i.Id);
                //}

                productCategory = category;
            }

            var productObj = new ProductListViewModel
            {
                GetProducts = products,
                ProductCategory = productCategory
            };

            ViewBag.Title = "All Products";
            return View(productObj);

            //ViewBag.Cars = "allCars";
            //CarsListViewModel obj = new CarsListViewModel();
            //obj.GetCars = _cars.GetCars;
            //obj.CarCategory = "auto";

            //return View(obj);
            //var cars = _cars.GetCars;
            //return View(cars);
        }
    }
}