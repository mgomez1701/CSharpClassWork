using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppPractice.Models;

namespace WebAppPractice.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GreetUser(Tester test)
        {
            return View(test);
        }
    }
}