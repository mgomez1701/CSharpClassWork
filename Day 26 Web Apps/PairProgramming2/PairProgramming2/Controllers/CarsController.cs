using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PairProgramming2.Models;

namespace PairProgramming2.Controllers
{
    public class CarsController : Controller
    {
        List<Cars> savedCars = new List<Cars>();
        public IActionResult Index()
        {

             return View();
            
        }

        public IActionResult ViewList()
        {
            string carJson = HttpContext.Session.GetString("CarListSession");
            if (carJson != null)
            {
                List<Cars> savedCars = JsonConvert.DeserializeObject<List<Cars>>(carJson);
                return View(savedCars);
            }
            else
            {
                return View();
            }
        }

        public IActionResult SaveCar(Cars newCar)
        {
            PopulateFromSession();
            savedCars.Add(newCar);
            HttpContext.Session.SetString("CarListSession",
            JsonConvert.SerializeObject(savedCars));

            return RedirectToAction("Index");
        }

        public void PopulateFromSession()
        {
            string carListJson = HttpContext.Session.GetString("CarListSession");
            if (carListJson != null)
            {
                savedCars = JsonConvert.DeserializeObject<List<Cars>>(carListJson);
            }

        }
    }
}