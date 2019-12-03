using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using API2WithKey.Models;
using Microsoft.AspNetCore.Mvc;

namespace API2WithKey.Controllers
{
    public class GiphyController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://api.giphy.com/v1/");

            string query = "grandcircusco";
            var response = await client.GetAsync($"gifs/search?api_key=4xR8CCIaF0xe9DCGRbDPnaYX8vEifJla&q={query}");

            //TODO ADD ReadAsAsync after nuget package downoad
            // NuGet package Microsoft.aspnet.webapi.client

            var giphy = await response.Content.ReadAsAsync<Giphy>();
            return View(giphy);
        }
    }
}