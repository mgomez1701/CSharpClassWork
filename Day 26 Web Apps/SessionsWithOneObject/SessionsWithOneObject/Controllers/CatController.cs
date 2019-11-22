using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SessionsWithOneObject.Models;

namespace SessionsWithOneObject.Controllers
{

   

    public class CatController : Controller
    {
        List<Cat> savedCats = new List<Cat>();
        public IActionResult Index()
        {
            string catJson = HttpContext.Session.GetString("CatListSession");
            // preferably you want to do this here but you can do it in the view too//
            if (catJson != null)
            {
                List<Cat> savedCats = JsonConvert.DeserializeObject<List<Cat>>(catJson);
                return View(savedCats);
            }
            else
            {
                return View();
            }
        }

        public IActionResult SaveCat(Cat newCat)// if we are binding the object into a model the variable (newCat) can have any name . deosnt need to match
        {
            PopulateFromSession();
            savedCats.Add(newCat);

            // we are taking  object of type cat, tunring into a sting with JSON, then we can convert string back to cat later on.
            HttpContext.Session.SetString("CatListtSession", 
            JsonConvert.SerializeObject(savedCats));

            return RedirectToAction("Index");
        }

        public void PopulateFromSession()
        {
            
            string catListJson = HttpContext.Session.GetString("CatListSession");
            if (catListJson != null)
            {
                savedCats = JsonConvert.DeserializeObject<List<Cat>>(catListJson);
            }

        }


    }
}