using RentCourse.Data.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RentCourse.Data.EFContext;
using RentCourse.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using RentCourse.Services;

namespace RentCourse.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<DbUser> _userManager;
        private readonly SignInManager<DbUser> _signInManager;
        private readonly RoleManager<DbRole> _roleManager;
        private readonly EFDbContext _context;

        public AccountController(UserManager<DbUser> userManager, SignInManager<DbUser> signInManager,
            RoleManager<DbRole> roleManager, EFDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _context = context;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            var user = _context.Users.FirstOrDefault(u => u.Email == model.Email);
            if (user == null)
            {
                ModelState.AddModelError("", "Неправильний логін");
                return View(model);
            }

            var result = _signInManager.PasswordSignInAsync(user, model.Password, false, false).Result;

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Неправильний пароль");
                return View(model);
            }

            await _signInManager.SignInAsync(user, isPersistent: false);

            await Authenticate(model.Email);

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            var roleName = "User";

            ////////////  Один раз
            //var resul = _roleManager.CreateAsync(new DbRole
            //{
            //    Name = roleName
            //}).Result;

            //roleName = "Admin";

            //resul = _roleManager.CreateAsync(new DbRole
            //{
            //    Name = roleName
            //}).Result;

            if (ModelState.IsValid)
            {
                UserProfile userProfile = new UserProfile
                {
                    FirstName = model.FirstName,
                    MiddleName = model.MiddleName,
                    LastName = model.LastName,
                    PhoneNumber=model.PhoneNumber,
                    RegistrationDate = DateTime.Now,
                    Email=model.Email
                };

                DbUser dbUser = new DbUser
                {
                    Email = model.Email,
                    UserName = model.Email,
                    UserProfile = userProfile
                };

                var result = await _userManager.CreateAsync(dbUser, model.Password);
                result = _userManager.AddToRoleAsync(dbUser, roleName).Result;

                if (result.Succeeded)
                {
                    // установка куки
                    await _signInManager.SignInAsync(dbUser, false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }

            }

            return View(model);
        }

        private async Task Authenticate(string userName)
        {
            // создаем один claim
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, userName)
            };
            // создаем объект ClaimsIdentity
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            // установка аутентификационных куки
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }

        public IActionResult AccessDenied()
        {
            return RedirectToAction("Login", "Account");
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            //await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }

        [HttpGet]
        public IActionResult RestorePassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RestorePassword(RestorePasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var user = _context.Users.FirstOrDefault(u => u.Email == model.Email);

            if (user == null)
            {
                ModelState.AddModelError("", "Incorrect Email");
                return View(model);
            }

            var UserName = user.Email;
            EmailService emailService = new EmailService();

            string url = "http://localhost:49855/Account/ChangePassword/" + user.Id;

            await emailService.SendEmailAsync(model.Email, "Restore Password",
                 $" Dear {UserName}," +
                    $" <br/>" +
                    $" To change your password" +
                    $" <br/>" +
                    $" you should visit this link <a href='{url}'>press</a>");

            return View(model);
        }

        [HttpGet]
        [Route("Account/ChangePassword/{id}")]
        public IActionResult ChangePassword(string id)
        {
            return View();
        }

        [HttpPost]
        [Route("Account/ChangePassword/{id}")]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model, string id)
        {
            if (ModelState.IsValid)
            {
                var user = _context.Users.FirstOrDefault(u => u.Id == id);
                if (user == null)
                {
                    ModelState.AddModelError("", "This User not register");
                    return View(model);
                }

                var hash_password = _userManager.PasswordHasher.HashPassword(user, model.Password);
                user.PasswordHash = hash_password;
                var result = await _userManager.UpdateAsync(user);

                //await _myEmailSender.SendEmailAsync("m.rogach777@gmail.com", "ForgotPassword",
                //    $" Dear {userName}," +
                //    $" <br/>" +
                //    $" To change your password" +
                //    $" <br/>" +
                //    $" you should visit this link <a href='{url}'>press</a>");
            }
            return RedirectToAction("Login", "Account");
        }
    }
}