using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPIExample2.Models;

namespace WebAPIExample2.Controllers
{
    public class WeatherController : Controller
    {
        public async Task<IActionResult> DisplayWeather()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://weatherbit-v1-mashape.p.rapidapi.com");
            client.DefaultRequestHeaders.Add("x-rapidapi-host", "weatherbit-v1-mashape.p.rapidapi.com");
            client.DefaultRequestHeaders.Add("x-rapidapi-key", "3be7761f78mshf4586a9755b5509p18a564jsnd22310709345");

            var response = await client.GetAsync("/current?lang=en&lon=28.3852&lat=81.5639");
            var categories = await response.Content.ReadAsAsync<WeatherRoot>();
            return View(categories);
        }
    }
}