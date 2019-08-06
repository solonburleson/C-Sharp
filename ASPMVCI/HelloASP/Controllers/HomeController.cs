using System;
using Microsoft.AspNetCore.Mvc;
namespace HelloASP
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult index()
        {
            return View();
        }

        [Route("hello")]
        [HttpGet]
        public RedirectToActionResult Hello()
        {
            Console.WriteLine("Hello There! Redirecting.....");
            return RedirectToAction("HelloUser", new{username="Solon", location="Dallas"});
        }

        [HttpGet("{username}/{location}")]
        public IActionResult HelloUser(string username, string location)
        {
            var response = new {user=username, place=location};
            if(location == "Dallas")
                return Json(response);
            else if(location =="Chicago")
                return View("index");
            return RedirectToAction("index");
        }
    }
}