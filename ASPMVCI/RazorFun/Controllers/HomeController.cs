using Microsoft.AspNetCore.Mvc;

namespace RazorFun
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult index()
        {
            return View();
        }
    }
}