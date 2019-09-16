using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace COMP2048_Lab2.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(string category)
        {
            // add selected category to VIewBag to display the brose page
            ViewBag.category = "You selected category: " + category;
            return View();
        }
    }
}