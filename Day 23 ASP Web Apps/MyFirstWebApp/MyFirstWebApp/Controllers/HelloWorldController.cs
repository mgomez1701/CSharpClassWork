using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstWebApp.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            string name = "iDontGamble";
            return View("Index",name);
        }
    }
}