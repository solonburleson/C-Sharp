using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace Dojodachi
{
    public class HomeController : Controller
    {
        [HttpGet("dojodachi")]
        public IActionResult index()
        {
            int? happy = HttpContext.Session.GetInt32("happy");
            int? full = HttpContext.Session.GetInt32("full");
            int? energy = HttpContext.Session.GetInt32("energy");
            int? meals = HttpContext.Session.GetInt32("meals");
            object message = TempData["message"];
            if(happy == null)
            {
                happy = 20;
                HttpContext.Session.SetInt32("happy", (int) happy);
                full = 20;
                HttpContext.Session.SetInt32("full", (int) full);
                energy = 50;
                HttpContext.Session.SetInt32("energy", (int) energy);
                meals = 3;
                HttpContext.Session.SetInt32("meals", (int) meals);
            }
            if(message == null)
            {
                message = "Welcome to Dojodachi!";
            }
            if(happy >= 100 && full >= 100 && energy >= 100)
            {
                ViewBag.status = "won";
                message = "Congratulations! You won!";
            }
            else if(energy == 0 || full == 0)
            {
                ViewBag.status = "lost";
            }
            else
            {
                ViewBag.status = "playing";
            }
            ViewBag.happy = happy;
            ViewBag.full = full;
            ViewBag.energy = energy;
            ViewBag.meals = meals;
            ViewBag.message = message;
            return View();
        }

        [HttpGet("feed")]
        public IActionResult feed()
        {
            int? meals = HttpContext.Session.GetInt32("meals");
            if(meals > 0)
            {
                int? full = HttpContext.Session.GetInt32("full");
                Random rand = new Random();
                int food = rand.Next(5,11);
                full += food;
                meals--;
                TempData["message"] = $"You fed your Dojodachi! Fullness: {full}, Meals Left: {meals}";
                HttpContext.Session.SetInt32("full", (int) full);
                HttpContext.Session.SetInt32("meals", (int) meals);
            }
            else
            {
                TempData["message"] = "Your dojodachi is out of meals! Try Work to get more";
            }
            return RedirectToAction("index");
        }

        [HttpGet("play")]
        public IActionResult play()
        {
            int? happy = HttpContext.Session.GetInt32("happy");
            int? energy = HttpContext.Session.GetInt32("energy");
            Random rand = new Random();
            int gain = rand.Next(5,11);
            energy -= 5;
            happy += gain;
            HttpContext.Session.SetInt32("happy", (int) happy);
            HttpContext.Session.SetInt32("energy", (int) energy);
            TempData["message"] = $"You played with your dojodachi! It gained {gain} Happiness. Happiness: {happy}";
            return RedirectToAction("index");
        }

        [HttpGet("work")]
        public IActionResult work()
        {
            Random rand = new Random();
            int? energy = HttpContext.Session.GetInt32("energy");
            int? meals = HttpContext.Session.GetInt32("meals");
            energy -= 5;
            meals += rand.Next(1,4);
            HttpContext.Session.SetInt32("energy", (int) energy);
            HttpContext.Session.SetInt32("meals", (int) meals);
            TempData["message"] = $"Your dojodachi worked and now has {meals} meals!";
            return RedirectToAction("index");
        } 

        [HttpGet("sleep")]
        public IActionResult sleep()
        {
            int? happy = HttpContext.Session.GetInt32("happy");
            int? full = HttpContext.Session.GetInt32("full");
            int? energy = HttpContext.Session.GetInt32("energy");
            energy += 15;
            full -= 5;
            happy -= 5;
            HttpContext.Session.SetInt32("happy", (int) happy);
            HttpContext.Session.SetInt32("energy", (int) energy);
            HttpContext.Session.SetInt32("full", (int) full);
            TempData["message"] = "Your dojodachi went to sleep!";
            return RedirectToAction("index");
        }

        [HttpGet("restart")]
        public IActionResult restart()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("index");
        }
    }
}