using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TempData.Controllers
{
    public class TempDataController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult First()
        {
            TempData["HaroldsKeys"] = "HaroldsValue";
            return View();
        }

        public IActionResult Second()
        {
            var Harold = TempData["HaroldsKey"];
            return View();
        }

        public IActionResult Third()
        {
            var Harold = TempData["HaroldsKey"];
            return View();

        }
    }
}