using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Web_Application_Engineering_Lab_4.Controllers
{
    public class Lab4Controller : Controller
    {
        public IActionResult Index()
        {
            DateTime curTime = DateTime.Now;

            return View(curTime);
        }

        public IActionResult Page2(int id)
        {
            return View(id);
        }

        public IActionResult Page3()
        {
            ViewData["Message"] = "Beverages Offered";

            string[] beverages =  {"Pepsi", "Coke", "Water", "Iced Tea", "Coffee", "Wine"};

            return View(beverages);
        }
    }
}