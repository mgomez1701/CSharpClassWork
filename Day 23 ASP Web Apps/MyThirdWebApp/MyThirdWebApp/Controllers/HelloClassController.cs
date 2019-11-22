using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyThirdWebApp.Models;

namespace MyThirdWebApp.Controllers
{
    public class HelloClassController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GreetUser(User user)
        {
            return View(user);
        }
    }
}