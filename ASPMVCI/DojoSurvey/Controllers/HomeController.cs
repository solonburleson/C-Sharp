using System;
using Microsoft.AspNetCore.Mvc;

namespace DojoSurvey
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult index()
        {
            return View();
        }

        [HttpPost("result")]
        public IActionResult result(string name, string location, string language, string comment)
        {
            if(name == null)
            {
                return RedirectToAction("index");
            }
            ViewBag.name = name;
            ViewBag.location = location;
            ViewBag.language = language;
            ViewBag.comment = comment;
            return View();
        }
    }
}