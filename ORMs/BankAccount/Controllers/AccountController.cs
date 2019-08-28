using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BankAccount.Models;
using Microsoft.AspNetCore.Http;

namespace BankAccount.Controllers
{
    public class AccountController : Controller
    {
        private MyContext dbContext;
        public AccountController(MyContext context)
        {
            dbContext = context;
        }

        [HttpGet("account/{id}")]
        public IActionResult Index(int id)
        {
            int? sessionId = HttpContext.Session.GetInt32("UserId");
            if(id != sessionId)
            {
                if(sessionId == null)
                {
                    return RedirectToAction("Index", "Home");
                }
                return RedirectToAction("Index", new { id = sessionId });
            }
            User thisUser = dbContext.Users.Where(user => user.UserId == id).FirstOrDefault();
            thisUser.Transactions = dbContext.Transactions.Where(t => t.UserId == thisUser.UserId).OrderByDescending(t => t.CreatedAt).ToList();
            double sum = 0;
            foreach (var t in thisUser.Transactions)
            {
                sum += t.Amount;
            }
            ViewBag.User = thisUser;
            ViewBag.sum = sum;
            return View();
        }

        [HttpPost("transaction/create")]
        public IActionResult Create(Transaction t)
        {
            int? sessionId = HttpContext.Session.GetInt32("UserId");
            t.UserId = (int) sessionId;
            dbContext.Add(t);
            dbContext.SaveChanges();
            return RedirectToAction("Index", new { id = sessionId });
        }
    }
}