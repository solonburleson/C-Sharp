using Microsoft.AspNetCore.Mvc;
using QuotingDojo.Models;
using DbConnection;
using System.Collections.Generic;
using System;

namespace QuotingDojo
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult index()
        {
            return View();
        }

        [HttpPost("quotes")]
        public IActionResult addQuote(Quotes thisQuote)
        {
            if(ModelState.IsValid)
            {
                string query = $"INSERT INTO quotes (Name, Quote, createdAt) VALUES ('{thisQuote.Name}', '{thisQuote.Quote}', CURRENT_TIMESTAMP)";
                DbConnector.Execute(query);
                return RedirectToAction("quotes");
            }
            return View("index");
        }

        [HttpGet("quotes")]
        public IActionResult quotes()
        {
            List<Dictionary<string,object>> allQuotes = DbConnector.Query("SELECT * FROM quotes ORDER BY createdAt DESC");
            ViewBag.quotes = allQuotes;
            return View();
        }
    }
}