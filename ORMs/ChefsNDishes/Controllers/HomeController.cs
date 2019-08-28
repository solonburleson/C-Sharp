using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChefsNDishes.Models;
using Microsoft.EntityFrameworkCore;

namespace ChefsNDishes.Controllers
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
            List<Chef> allChefs = dbContext.Chefs.ToList();
            foreach (var chef in allChefs)
            {
                chef.CreatedDishes = dbContext.Dishes.Where(dish => dish.ChefId == chef.ChefId).ToList();
            }
            return View(allChefs);
        }

        [HttpGet("new")]
        public IActionResult Newchef()
        {
            return View();
        }

        [HttpPost("create")]
        public IActionResult Create(Chef thisChef)
        {
            if(ModelState.IsValid)
            {
                DateTime today = DateTime.Now;
                int result = DateTime.Compare(thisChef.DOB, today);
                if(result > 0)
                {
                    ModelState.AddModelError("DOB", "Date must be before today!");
                    return View("Newchef");
                }
                TimeSpan difference = today - thisChef.DOB;
                double years = difference.TotalDays / 365.25;
                if(years < 18)
                {
                    ModelState.AddModelError("DOB", "Chef must be 18 years old");
                    return View("Newchef");
                }
                dbContext.Add(thisChef);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Newchef");
        }
    }
}
