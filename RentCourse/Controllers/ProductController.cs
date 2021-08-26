using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
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
        private readonly UserManager<DbUser> _userManager;

        public ProductController(IProducts products, ICategories category, ITypes type, IHostingEnvironment env, EFDbContext context, ILocations location, UserManager<DbUser> userManager)
        {
            _userManager = userManager;
            _products = products;
            _category = category;
            _type = type;
            _env = env;
            _context = context;
            _location = location;
        }
        [Route("Product/MainThings")]
        public ViewResult MainThings(string search, string category, string location, double minprice, double maxprice, string sort)
        {
            IEnumerable<Product> products = null;
            string productCategory = "";
            string productLocation = "";
            string type = "MainThings";

            if (category != null)
            {
                products = _products.GetProducts(type, category, location, sort, search, minprice, maxprice);
                productCategory = category;
                productLocation = location;
            }
            else
            {
                products = _products.GetAvProducts.Where(x => x.Category.TypeId == _type.Types.FirstOrDefault(t => t.Name == type).Id);
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
        public ViewResult MainRealEstate(string search, string category, string location, double minprice, double maxprice, string sort)
        {
            IEnumerable<Product> products = null;
            string productCategory = "";
            string productLocation = "";
            string type = "MainRealEstate";

            if (category != null)
            {
                products = _products.GetProducts(type, category, location, sort, search, minprice, maxprice);
                productCategory = category;
                productLocation = location;
            }
            else
            {
                products = _products.GetAvProducts.Where(x => x.Category.TypeId == _type.Types.FirstOrDefault(t => t.Name == type).Id);
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
        public ViewResult MainCars(string search, string category, string location, double minprice, double maxprice, string sort)
        {
            IEnumerable<Product> products = null;
            string productCategory = "";
            string productLocation = "";
            string type = "MainCars";

            if (category != null)
            {
                products = _products.GetProducts(type, category, location, sort, search, minprice, maxprice);
                productCategory = category;
                productLocation = location;
            }
            else
            {
                products = _products.GetAvProducts.Where(x => x.Category.TypeId == _type.Types.FirstOrDefault(t => t.Name == type).Id);
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
                var id = _userManager.GetUserAsync(User).Result.Id;
                var userprof = _context.UserProfile.FirstOrDefault(x => x.Id == id);
                Product product = new Product
                {
                    Title = model.Title,
                    Description = model.Description,
                    CategoryId = model.CategotyId,
                    Price = model.Price,
                    Available = true,
                    DateOfPublication = DateTime.Now,
                    LocationId = model.LocationId,
                    UserId = _userManager.GetUserAsync(User).Result.Id,
                    User = userprof,
                    ViewCount = 0,
                    Image = uploadedFile.FileName,
                    Category = _category.Categories.FirstOrDefault(x => x.Id == model.CategotyId),
                    Location = _location.Locations.FirstOrDefault(x => x.Id == model.LocationId)
                };

                _context.Products.Add(product);
                _context.SaveChanges();

                return RedirectToAction("Index", "Home");
            }
            else
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors);
            }
            return View();
        }

        public ViewResult Favorites()
        {
            var id = _userManager.GetUserAsync(User).Result.Id;
            var userfavs = _context.UserFavorites.Where(x => x.UserId == id);
            List<Product> products = new List<Product>();
            foreach (var item in userfavs)
            {
                products.Add(_products.GetAvProducts.FirstOrDefault(x => x.Id == item.ProductId));
            }
            var productObj = new FavoritesViewModel
            {
                Products = products
            };

            return View(productObj);
        }

        [HttpGet]
        public IActionResult EditProduct()
        {
            return View();
        }

        [Authorize(Roles = "User")]
        [HttpPost]
        public async Task<IActionResult> EditProduct(EditProductViewModel model, DbUser user, IFormFile uploadedFile)
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
                var id = model.UserId;
                var userprof = _context.UserProfile.FirstOrDefault(x => x.Id == id);
                Product product = _context.Products.FirstOrDefault(x => x.Id == model.ProductId);

                product.Title = model.Title;
                product.Description = model.Description;
                product.Price = model.Price;
                if (uploadedFile != null)
                {
                    product.Image = model.ImageName;
                }

                _context.Products.Update(product);
                _context.SaveChanges();

                return RedirectToAction("PersonalPage", "Account");
            }
            else
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors);
            }
            return View();
        }
    }
}
