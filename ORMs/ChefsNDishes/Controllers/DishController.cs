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
    public class DishController : Controller
    {
        private MyContext dbContext;
        public DishController(MyContext context)
        {
            dbContext = context;
        }

        [HttpGet("dishes")]
        public IActionResult Index()
        {
            List<Dish> allDishes = dbContext.Dishes.ToList();
            foreach (var dish in allDishes)
            {
                dish.Creator = dbContext.Chefs.Where(chef => chef.ChefId == dish.ChefId).FirstOrDefault();
            }
            return View(allDishes);
        }

        [HttpGet("dishes/new")]
        public IActionResult New()
        {
            List<Chef> allChefs = dbContext.Chefs.ToList();
            ViewBag.allChefs = allChefs;
            return View();
        }

        [HttpPost("dishes/create")]
        public IActionResult Create(Dish thisDish)
        {
            if(ModelState.IsValid)
            {
                dbContext.Add(thisDish);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("New");
        }
    }
}