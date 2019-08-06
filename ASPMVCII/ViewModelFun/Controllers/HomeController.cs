using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;
using System.Collections.Generic;

namespace ViewModelFun
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult index()
        {
            string str = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque eget sapien in eros finibus interdum et at dolor.";
            return View("index", str);
        }

        [HttpGet("numbers")]
        public ViewResult numbers()
        {
            int[] numbers = {1,2,3,10,43,5};
            return View(numbers);
        }

        [HttpGet("users")]
        public ViewResult users()
        {
            List<User> users = new List<User>();
            User moose = new User();
            moose.FirstName = "Moose";
            moose.LastName = "Willis";
            User sarah = new User();
            sarah.FirstName = "Sarah";
            User jerry = new User();
            jerry.FirstName = "Jerry";
            User rene = new User();
            rene.FirstName = "Rene";
            rene.LastName = "Ricky";
            User barb = new User();
            barb.FirstName = "Barbarah";
            users.Add(moose);
            users.Add(sarah);
            users.Add(jerry);
            users.Add(rene);
            users.Add(barb);
            return View(users);
        }

        [HttpGet("user")]
        public ViewResult user()
        {
            User thisUser = new User();
            thisUser.FirstName = "Moose";
            thisUser.LastName = "Willis";
            return View(thisUser);
        }
    }
}