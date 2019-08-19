using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CRUDelicious.Models;

namespace CRUDelicious.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
        public HomeController(MyContext context)
        {
            dbContext = context;
        }
        public IActionResult Index()
        {
            List<Dish> allDishes = dbContext.Dishes.OrderByDescending(dish => dish.CreatedAt).ToList();
            return View(allDishes);
        }

        [HttpGet("new")]
        public IActionResult New()
        {
            return View();
        }

        [HttpPost("create")]
        public IActionResult create(Dish thisDish)
        {
            if(ModelState.IsValid)
            {
                dbContext.Add(thisDish);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("New");
        }

        [HttpGet("{id}")]
        public IActionResult Dish(int id)
        {
            Dish thisDish = dbContext.Dishes.SingleOrDefault(dish => dish.DishId == id);
            return View(thisDish);
        }

        [HttpGet("edit/{id}")]
        public IActionResult EditDish(int id)
        {
            Dish thisDish = dbContext.Dishes.SingleOrDefault(dish => dish.DishId == id);
            return View(thisDish);
        }

        [HttpPost("updateDish")]
        public IActionResult UpdateDish(Dish updateDish)
        {
            if(ModelState.IsValid)
            {
                Console.WriteLine("Saving");
                //Can't get ID to pass through route & Dish object has ID of 0, had to go by name not ideal
                Dish thisDish = dbContext.Dishes.FirstOrDefault(dish => dish.Name == updateDish.Name);
                thisDish.Name = updateDish.Name;
                thisDish.Chef = updateDish.Chef;
                thisDish.Tastiness = updateDish.Tastiness;
                thisDish.Calories = updateDish.Calories;
                thisDish.Description = updateDish.Description;
                thisDish.UpdatedAt = DateTime.Now;
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("EditDish", updateDish);
        }

        [HttpGet("delete/{id}")]
        public IActionResult DeleteDish(int id)
        {
            Dish thisDish = dbContext.Dishes.SingleOrDefault(dish => dish.DishId == id);
            dbContext.Dishes.Remove(thisDish);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
