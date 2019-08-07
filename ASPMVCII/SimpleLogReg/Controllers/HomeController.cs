using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpleLogReg.Models;

namespace SimpleLogReg.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("register")]
        public IActionResult register(RegUser registerUser)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("success");
            }
            return View("Index");
        }

        [HttpPost("login")]
        public IActionResult login(LogUser loginUser)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("success");
            }
            return View("Index");
        }

        [HttpGet("success")]
        public IActionResult success()
        {
            return View("Success");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
