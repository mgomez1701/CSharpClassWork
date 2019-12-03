using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TestingApis.Models;

namespace TestingApis.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        // we use async when we call API
        public async Task<IActionResult> AddEmployee(Employee employee)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44340/");
            
            // make sure to download the client
            var response = await client.PostAsJsonAsync("api/Company",employee);

            return RedirectToAction("Index"); // this is where we would send them to see the new list of employees

        }
    }
}