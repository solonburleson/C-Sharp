using Microsoft.AspNetCore.Mvc;
namespace Portfolio
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult home()
        {
            return View();
        }

        [HttpGet("projects")]
        public ViewResult projects()
        {
            return View();
        }

        [HttpGet("contact")]
        public ViewResult contact()
        {
            return View();
        }
    }
}