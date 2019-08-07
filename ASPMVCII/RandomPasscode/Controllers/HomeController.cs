using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace RandomPasscode
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult index()
        {
            string alphanum = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string passcode = "";
            int? count = HttpContext.Session.GetInt32("count");
            Random rand = new Random();
            while(passcode.Length < 14)
            {
                int index = rand.Next(0, alphanum.Length);
                passcode += alphanum[index];
            }
            if(count == null)
            {
                count = 0;
            }
            count++;
            HttpContext.Session.SetInt32("count", (int) count);
            ViewBag.count = count;
            ViewBag.passcode = passcode;
            return View();
        }

        [HttpPost("count")]
        public IActionResult count()
        {
            return RedirectToAction("index");
        }
    }
}