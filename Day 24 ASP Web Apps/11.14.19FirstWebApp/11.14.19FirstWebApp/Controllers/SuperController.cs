using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _11._14._19FirstWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace _11._14._19FirstWebApp.Controllers
{
    public class SuperController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult DisplaySupers(string selection)
        {
            if (selection == "Heros")
            {
                DataClass.FillPowers(DataClass.superHeros);
                return View(DataClass.superHeros);
            }
            else
            {
                DataClass.FillPowers(DataClass.superVillains);
                return View(DataClass.superVillains);
            }
        }
        [HttpGet]
        public IActionResult AddSuper()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddSuper(Supers newSuper)
        {
            if (ModelState.IsValid) // this is validation in the controller. You are validating user input matches all the required props.
            {
                if (newSuper.GoodOrBad)
                {
                    DataClass.superHeros.Add(newSuper);
                    return View("DisplaySupers", DataClass.superHeros);
                }
                else
                {
                    DataClass.superVillains.Add(newSuper);
                    return View("DisplaySupers", DataClass.superVillains);
                }
          
            }
            else
            {
                return View();
            }

        }
    }
}