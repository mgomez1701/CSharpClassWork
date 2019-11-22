using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppRedo.Models;

namespace WebAppRedo.Controllers
{ 
    
    public class UFCFightersController : Controller
    {
        public static List<UFCFighters> titleHolder = new List<UFCFighters>
        {

        };
        public IActionResult Index()
        {
            return View();
        }
    }
}