using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BankAccount.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace BankAccount.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
        public HomeController(MyContext context)
        {
            dbContext = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("create")]
        public IActionResult Create(User thisUser)
        {
            if(ModelState.IsValid)
            {
                if(dbContext.Users.Any(u => u.Email == thisUser.Email))
                {
                    ModelState.AddModelError("Email", "Email Address is already registered!");
                    return View("Index");
                }
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                thisUser.Password = Hasher.HashPassword(thisUser, thisUser.Password);
                dbContext.Add(thisUser);
                dbContext.SaveChanges();
                HttpContext.Session.SetInt32("UserId", thisUser.UserId);
                return RedirectToAction("Index", "Account", new { id = thisUser.UserId });
            }
            return View("Index");
        }

        [HttpGet("login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("validate")]
        public IActionResult Validate(LoginUser loginUser)
        {
            User usercheck = dbContext.Users.FirstOrDefault(u => u.Email == loginUser.Email);
            if(usercheck == null)
            {
                ModelState.AddModelError("Email", "Invalid credentials. Please check email and password.");
                return View("Login");
            }
            var hasher = new PasswordHasher<LoginUser>();
            var result = hasher.VerifyHashedPassword(loginUser, usercheck.Password, loginUser.Password);
            if(result == 0)
            {
                ModelState.AddModelError("Password", "Invalid credentials. Please check email and password.");
                return View("Login");
            }
            HttpContext.Session.SetInt32("UserId", usercheck.UserId);
            return RedirectToAction("Index", "Account", new { id = usercheck.UserId });
        }
    }
}
