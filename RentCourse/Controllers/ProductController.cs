using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentCourse.Components;
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
        private readonly ILocations _location;
        private readonly EFDbContext _context;

        public ProductController(IProducts products, ICategories category, ITypes type, IHostingEnvironment env, EFDbContext context, ILocations location)
        {
            _products = products;
            _category = category;
            _type = type;
            _env = env;
            _context = context;
            _location = location;
        }
        [Route("Product/MainThings")]
        [Route("Product/MainThings/{category}")]
        public ViewResult MainThings(string category)
        {
            IEnumerable<Product> products = null;
            string productCategory = "";
            string type = "MainThings";
            if (string.IsNullOrEmpty(category))
            {
                products = _products.GetAllProducts
                    .Where(x => x.Category.TypeId == _type.Types.FirstOrDefault(y => y.Name.ToLower() == type.ToLower()).Id);
            }
            else
            {
                products = _products.GetAllProducts
                    .Where(x => x.Category.TypeId == _type.Types.FirstOrDefault(y => y.Name.ToLower() == type.ToLower()).Id)
                    .Where(x => x.Category.Name.ToLower() == category.ToLower());

                productCategory = category;
            }

            var productObj = new ProductListViewModel
            {
                GetProducts = products,
                ProductCategory = productCategory,
                ProductType = type
            };

            return View(productObj);
        }

        [Route("Product/MainRealEstate")]
        [Route("Product/MainRealEstate/{category}")]
        public ViewResult MainRealEstate(string category)
        {
            IEnumerable<Product> products = null;
            string productCategory = "";
            string type = "MainRealEstate";
            if (string.IsNullOrEmpty(category))
            {
                products = _products.GetAllProducts
                    .Where(x => x.Category.TypeId == _type.Types.FirstOrDefault(y => y.Name.ToLower() == type.ToLower()).Id);
            }
            else
            {
                products = _products.GetAllProducts
                    .Where(x => x.Category.TypeId == _type.Types.FirstOrDefault(y => y.Name.ToLower() == type.ToLower()).Id)
                    .Where(x => x.Category.Name.ToLower() == category.ToLower());

                productCategory = category;
            }

            var productObj = new ProductListViewModel
            {
                GetProducts = products,
                ProductCategory = productCategory,
                ProductType = type
            };

            return View(productObj);
        }

        [Route("Product/MainCars")]
        [Route("Product/MainCars/{category}")]
        public ViewResult MainCars(string category)
        {
            IEnumerable<Product> products = null;
            string productCategory = "";
            string type = "MainCars";
            if (string.IsNullOrEmpty(category))
            {
                products = _products.GetAllProducts
                    .Where(x => x.Category.TypeId == _type.Types.FirstOrDefault(y=>y.Name.ToLower()==type.ToLower()).Id);
            }
            else
            {
                products = _products.GetAllProducts
                    .Where(x => x.Category.TypeId == _type.Types.FirstOrDefault(y => y.Name.ToLower() == type.ToLower()).Id)
                    .Where(x => x.Category.Name.ToLower() == category.ToLower());

                productCategory = category;
            }

            var productObj = new ProductListViewModel
            {
                GetProducts = products,
                ProductCategory = productCategory,
                ProductType = type
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
                            LocationId = model.LocationId,
                            UserId = user.Id,
                            ViewCount = 0,
                            Image=fileName,
                            Category=_category.Categories.FirstOrDefault(x=>x.Id==model.CategotyId)
                            //Location=_location.Locations.FirstOrDefault(x=>x.Id==model.LocationId)
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
