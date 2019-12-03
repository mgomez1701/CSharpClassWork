using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPICatEx.Models;

namespace WebAPICatEx.Controllers
{
    public class CatController : Controller
    {
        //step 6 changed index name and ADD async Task<IActionResult>
        //ste 7 create link in layout to match DisplayCategories
        public async Task<IActionResult> DisplayCategories()
        {
            //step 8 create HTTP client, add using statment 

            var client = new HttpClient();
            //step 9 add base address from website
            client.BaseAddress = new Uri("https://api.thecatapi.com/");
            //step 10 sending over the header that is required for this API.
            client.DefaultRequestHeaders.Add("x-api-key", "48bc7bd6-427e-4d25-b609-3d04dfdbea9b");
            //step 11 create a repsonse
            var respone = await client.GetAsync("v1/categories"); // we need to INSTALL a nuget package at this point - Microsoft.AspNet.WebApi.Client
            //step 12 creat list of catagories, you will need to add a using statement for Categories
            var categories = await respone.Content.ReadAsAsync<List<Cats>>();
            return View(categories);
        }

        public async Task<IActionResult> DisplayByCategory(string category)
        {
            var client = new HttpClient();
          
            client.BaseAddress = new Uri("https://api.thecatapi.com/");
            client.DefaultRequestHeaders.Add("x-api-key", "48bc7bd6-427e-4d25-b609-3d04dfdbea9b");
            //TODO: find the Get Method for cat by category 
            // Add $ to ADD category 
            var respone = await client.GetAsync($"images/search?category_ids={category}"); 
            //TODO Create the Cat class via the Json from the Cat API Documentation
            var cat = await respone.Content.ReadAsAsync<List<Cats>>();
            var thisCat = cat[0].name;
            return View(thisCat);
        }

    }
}