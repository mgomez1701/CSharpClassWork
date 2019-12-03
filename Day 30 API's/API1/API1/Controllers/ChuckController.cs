using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using API1.Models;
using Microsoft.AspNetCore.Mvc;

namespace API1.Controllers
{
    // basic syntax for calling a basic api that does not have crazy keys or parameterss.
    public class ChuckController : Controller
    {
        public async Task<IActionResult> ChuckJoke()
        {
            var client = new HttpClient();
            //here we are talking ot the base address
            client.BaseAddress = new Uri("https://api.icndb.com");

            //await keyword tells the program to pause here because the program is running asyncroniusly
            var response = await client.GetAsync("jokes/random");

            var joke = await response.Content.ReadAsAsync<Chuck>();

            return View(joke);
        }

        public async Task<IActionResult> UserNameJoke(string FirstName, string LastName)
        {
            var client = new HttpClient();
            //set the base adress
            client.BaseAddress = new Uri("https://api.icndb.com");

            var response = await client.GetAsync($"jokes/random?firstName={FirstName}&lastName={LastName}");
            var joke = await response.Content.ReadAsAsync<Chuck>();

            return View("ChuckJoke", joke);

        }

    

    }
}