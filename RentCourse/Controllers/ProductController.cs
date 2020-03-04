using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentCourse.Data.EFContext;
using RentCourse.Data.Interfaces;
using RentCourse.Data.Models;
using RentCourse.ViewModels;

namespace RentCourse.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProducts _products;
        private readonly ICategories _category;
        private readonly IHostingEnvironment _env;
        private readonly ITypes _type;
        private readonly EFDbContext _context;

        public ProductController(IProducts products, ICategories category, ITypes type, IHostingEnvironment env, EFDbContext context)
        {
            _products = products;
            _category = category;
            _type = type;
            _env = env;
            _context = context;
        }
        //[Authorize(Roles = "User")]
        [Route("Home/{type}")]
        [Route("Home/{type}/{category}")]
        public ViewResult ListProducts(string type,string category)
        {
            IEnumerable<Product> products = null;
            string productCategory = "";
            string productType = "";
            if (string.IsNullOrEmpty(type))
            {
                products = _products.GetAllProducts.OrderBy(i => i.Id);
            }
            else if (string.IsNullOrEmpty(category) && !string.IsNullOrEmpty(type))
            {
                products = _products.GetAllProducts
                    .Where(x=>x.Category.CategoryType.Name.ToLower()==type.ToLower());
            }
            else
            {
                products = _products.GetAllProducts
                    .Where(x => x.Category.CategoryType.Name.ToLower() == type.ToLower())
                    .Where(x=>x.Category.Name.ToLower()==category.ToLower());

                productCategory = category;
                productType = type;
            }

            var productObj = new ProductListViewModel
            {
                GetProducts = products,
                ProductCategory = productCategory,
                ProductType=productType
            };

            return View(productObj);

        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        [Authorize(Roles = "User")]
        [HttpPost]
        public async Task<IActionResult> AddProduct(AddProductViewModel model, DbUser user, IFormFile uploadedFile)
        {
            if (ModelState.IsValid)
            {
                if (uploadedFile != null && uploadedFile.Length > 0)
                {
                    var file = uploadedFile;

                    if (file.Length > 0)
                    {

                        var folderServerPath = _env.ContentRootPath;
                        var folderName = "Uploaded";
                        var fileName = Guid.NewGuid().ToString() + ".jpg";
                        var savefile = Path.Combine(folderServerPath, folderName, fileName);
                        using (var stream = System.IO.File.Create(savefile))
                        {
                            await uploadedFile.CopyToAsync(stream);
                        }

                        Product product = new Product
                        {
                            Title = model.Title,
                            Description = model.Description,
                            CategoryId = model.CategotyId,
                            Price = model.Price,
                            Available = true,
                            DateOfPublication = DateTime.Now,
                            Location = model.Location,
                            UserId = user.Id
                        };

                        _context.Products.Add(product);
                        _context.SaveChanges();
                    }
                }
                return RedirectToAction("Index");
            }
            else
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors);
            }
            return View();
        }
    }
}

//if (ModelState.IsValid)
//            {
//                if (uploadedFile != null && uploadedFile.Length > 0)
//                {
//                    var file = uploadedFile;
//                    //var uploads = Path.Combine(_env.WebRootPath, "\\image");

//                    if (file.Length > 0)
//                    {

//                        var folderServerPath = _env.ContentRootPath;
//var folderName = "Uploaded";
//var fileName = Guid.NewGuid().ToString() + ".jpg";
//var savefile = Path.Combine(folderServerPath, folderName, fileName);
//                        using (var stream = System.IO.File.Create(savefile))
//                        {
//                            await uploadedFile.CopyToAsync(stream);
//                        }

//                        Car cartmp = new Car
//                        {
//                            Availabel = true,
//                            CategoryId = 1,
//                            Name = car.Name,
//                            Price = Convert.ToInt32(car.Price),
//                            Image = fileName
//                        };

//_context.Cars.Add(cartmp);
//                        _context.SaveChanges();
//                    }
//                }


//                return RedirectToAction("Index");

//            }
//            else
//            {
//                var errors = ModelState.Values.SelectMany(v => v.Errors);
//            }
//            return View();