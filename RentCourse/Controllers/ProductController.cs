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
using RentCourse.Models;
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
        [Route("Product/MainThings/{location}")]
        [Route("Product/MainThings/{category}/{location}")]
        public ViewResult MainThings(string category, string location)
        {
            IEnumerable<Product> products = null;
            string productCategory = "";
            string productLocation = "";
            string type = "MainThings";
            if (string.IsNullOrEmpty(category) && string.IsNullOrEmpty(location))
            {
                products = _products.GetAllProducts
                    .Where(x => x.Category.TypeId == _type.Types.FirstOrDefault(y => y.Name.ToLower() == type.ToLower()).Id);
            }
            else if (string.IsNullOrEmpty(category) && !string.IsNullOrEmpty(location))
            {
                products = _products.GetAllProducts
                    .Where(x => x.Category.TypeId == _type.Types.FirstOrDefault(y => y.Name.ToLower() == type.ToLower()).Id)
                    .Where(x => x.LocationId == _location.Locations.FirstOrDefault(a => a.City.ToLower() == location.ToLower()).Id);

                productLocation = location;
            }
            else if (!string.IsNullOrEmpty(category) && string.IsNullOrEmpty(location))
            {
                products = _products.GetAllProducts
                    .Where(x => x.Category.TypeId == _type.Types.FirstOrDefault(y => y.Name.ToLower() == type.ToLower()).Id)
                    .Where(x => x.Category.Name.ToLower() == category.ToLower());

                productCategory = category;
            }
            else
            {
                products = _products.GetAllProducts
                    .Where(x => x.Category.TypeId == _type.Types.FirstOrDefault(y => y.Name.ToLower() == type.ToLower()).Id)
                    .Where(x => x.Category.Name.ToLower() == category.ToLower())
                    .Where(x => x.LocationId == _location.Locations.FirstOrDefault(a => a.City.ToLower() == location.ToLower()).Id);

                productCategory = category;
                productLocation = location;
            }

            var productObj = new ProductListViewModel
            {
                GetProducts = products,
                ProductCategory = productCategory,
                ProductLocation = productLocation,
                ProductType = type
            };

            return View(productObj);
        }

        [Route("Product/MainRealEstate")]
        [Route("Product/MainRealEstate/{category}")]
        [Route("Product/MainRealEstate/{location}")]
        [Route("Product/MainRealEstate/{category}/{location}")]
        public ViewResult MainRealEstate(string category, string location)
        {
            IEnumerable<Product> products = null;
            string productCategory = "";
            string productLocation = "";
            string type = "MainRealEstate";
            if (string.IsNullOrEmpty(category) && string.IsNullOrEmpty(location))
            {
                products = _products.GetAllProducts
                    .Where(x => x.Category.TypeId == _type.Types.FirstOrDefault(y => y.Name.ToLower() == type.ToLower()).Id);
            }
            else if (string.IsNullOrEmpty(category) && !string.IsNullOrEmpty(location))
            {
                products = _products.GetAllProducts
                    .Where(x => x.Category.TypeId == _type.Types.FirstOrDefault(y => y.Name.ToLower() == type.ToLower()).Id)
                    .Where(x => x.LocationId == _location.Locations.FirstOrDefault(a=>a.City.ToLower()==location.ToLower()).Id);

                productLocation = location;
            }
            else if (!string.IsNullOrEmpty(category) && string.IsNullOrEmpty(location))
            {
                products = _products.GetAllProducts
                    .Where(x => x.Category.TypeId == _type.Types.FirstOrDefault(y => y.Name.ToLower() == type.ToLower()).Id)
                    .Where(x => x.Category.Name.ToLower() == category.ToLower());

                productCategory = category;
            }
            else
            {
                products = _products.GetAllProducts
                    .Where(x => x.Category.TypeId == _type.Types.FirstOrDefault(y => y.Name.ToLower() == type.ToLower()).Id)
                    .Where(x => x.Category.Name.ToLower() == category.ToLower())
                    .Where(x => x.LocationId == _location.Locations.FirstOrDefault(a => a.City.ToLower() == location.ToLower()).Id);

                productCategory = category;
                productLocation = location;
            }

            var productObj = new ProductListViewModel
            {
                GetProducts = products,
                ProductCategory = productCategory,
                ProductLocation = productLocation,
                ProductType = type
            };

            return View(productObj);
        }

        [Route("Product/MainCars")]
        [Route("Product/MainCars/{category}")]
        [Route("Product/MainCars/{location}")]
        [Route("Product/MainCars/{category}/{location}")]
        public ViewResult MainCars(string category, string location)
        {
            IEnumerable<Product> products = null;
            string productCategory = "";
            string productLocation = "";
            string type = "MainCars";
            if (string.IsNullOrEmpty(category) && string.IsNullOrEmpty(location))
            {
                products = _products.GetAllProducts
                    .Where(x => x.Category.TypeId == _type.Types.FirstOrDefault(y => y.Name.ToLower() == type.ToLower()).Id);
            }
            else if(string.IsNullOrEmpty(category) && !string.IsNullOrEmpty(location))
            {
                products = _products.GetAllProducts
                    .Where(x => x.Category.TypeId == _type.Types.FirstOrDefault(y => y.Name.ToLower() == type.ToLower()).Id)
                    .Where(x => x.LocationId == _location.Locations.FirstOrDefault(a => a.City.ToLower() == location.ToLower()).Id);

                productLocation = location;
            }
            else if (!string.IsNullOrEmpty(category) && string.IsNullOrEmpty(location))
            {
                products = _products.GetAllProducts
                    .Where(x => x.Category.TypeId == _type.Types.FirstOrDefault(y => y.Name.ToLower() == type.ToLower()).Id)
                    .Where(x => x.Category.Name.ToLower() == category.ToLower());

                productCategory = category;
            }
            else
            {
                products = _products.GetAllProducts
                    .Where(x => x.Category.TypeId == _type.Types.FirstOrDefault(y => y.Name.ToLower() == type.ToLower()).Id)
                    .Where(x => x.Category.Name.ToLower() == category.ToLower())
                    .Where(x => x.LocationId == _location.Locations.FirstOrDefault(a => a.City.ToLower() == location.ToLower()).Id);

                productCategory = category;
                productLocation = location;
            }

            var productObj = new ProductListViewModel
            {
                GetProducts = products,
                ProductCategory = productCategory,
                ProductLocation = productLocation,
                ProductType = type
            };

            return View(productObj);
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            var productObj = new AddProductViewModel
            {
                GetCategories = _category.Categories,
                GetLocations = _location.Locations
            };

            return View(productObj);
        }

        [Authorize(Roles = "User")]
        [HttpPost]
        public async Task<IActionResult> AddProduct(AddProductViewModel model, DbUser user, IFormFile uploadedFile)
        {
            if (ModelState.IsValid)
            {
                if (uploadedFile != null && uploadedFile.Length > 0)
                {
                    // путь к папке Files
                    string path = "/Files/" + uploadedFile.FileName;
                    // сохраняем файл в папку Files в каталоге wwwroot
                    using (var fileStream = new FileStream(_env.WebRootPath + path, FileMode.Create))
                    {
                        await uploadedFile.CopyToAsync(fileStream);
                    }
                    FileModel file = new FileModel { Name = uploadedFile.FileName, Path = path };
                    _context.Files.Add(file);
                    _context.SaveChanges();
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
                    Image = uploadedFile.FileName,
                    Category = _category.Categories.FirstOrDefault(x => x.Id == model.CategotyId),
                    Location = _location.Locations.FirstOrDefault(x => x.Id == model.LocationId)
                };

                _context.Products.Add(product);
                _context.SaveChanges();

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
