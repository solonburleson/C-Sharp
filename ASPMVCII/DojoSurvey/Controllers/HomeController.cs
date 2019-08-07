using System;
using Microsoft.AspNetCore.Mvc;
using DojoSurvey.Models;

namespace DojoSurvey
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult index()
        {
            return View();
        }

        [HttpPost("survey")]
        public IActionResult survey(Survey yourSurvey)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("result", yourSurvey);
            }
            else
            {
                return View("index");
            }
        }

        [HttpGet("result")]
        public IActionResult result(Survey yourSurvey)
        {
            return View(yourSurvey);
        }
    }
}