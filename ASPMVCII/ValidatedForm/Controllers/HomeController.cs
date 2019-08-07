using Microsoft.AspNetCore.Mvc;
using ValidatedForm.Models;

namespace ValidatedForm
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult index()
        {
            return View();
        }

        [HttpPost("survey")]
        public IActionResult submit(User thisUser)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("success", thisUser);
            }
            else
            {
                return View("index", thisUser);
            }
        }

        [HttpGet("success")]
        public IActionResult success(User thisUser)
        {
            return View();
        }
    }
}