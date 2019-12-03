using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using BrewreyAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace BrewreyAPI.Controllers
{
    public class BreweryController : Controller
    {
        public async Task<IActionResult> DisplayBrewery(string state)
        {
            var client = new HttpClient();

            client.BaseAddress = new Uri("https://brianiswu-open-brewery-db-v1.p.rapidapi.com/");
            client.DefaultRequestHeaders.Add("x-rapidapi-host", "brianiswu-open-brewery-db-v1.p.rapidapi.com");
            client.DefaultRequestHeaders.Add("x-rapidapi-key", "3be7761f78mshf4586a9755b5509p18a564jsnd22310709345");

            var response = await client.GetAsync($"breweries?by_state={state}");
            var categories = await response.Content.ReadAsAsync<List<Brewery>>();
            return View(categories);
        }
    }
}