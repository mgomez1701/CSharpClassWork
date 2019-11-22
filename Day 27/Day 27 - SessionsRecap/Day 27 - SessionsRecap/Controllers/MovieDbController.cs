using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day_27___SessionsRecap.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Day_27___SessionsRecap.Controllers
{
    


    public class MovieDbController : Controller
    {//1. Create an empty private list of movies that will be used to access a session of saved movies
        private List<Movies> userFavorites = new List<Movies>();
        private readonly MOVIE_DbContext _database;

        public MovieDbController(MOVIE_DbContext database)
        {
            _database = database;
        }
        public IActionResult Index()
        {
            var movieList = _database.Movies.ToList();
            return View(movieList);
        }

        public IActionResult AddToFavorites(int id)
        {
            var foundMovie = _database.Movies.Find(id);
            //5. call the PopulateFavorites whenever you want to access the list of Favorited movies.
            PopulateFavorites();
            //6. add the new favoroite movies to the populated list of favorited movies
            userFavorites.Add(foundMovie);
            //7. set the session to the newly edited list of favorited movies
            HttpContext.Session.SetString("FavoriteMovies", JsonConvert.SerializeObject(userFavorites));
            return View("ListFavorites", userFavorites); // we are sending the new list here  with userFavorites

        }

        // 2. create a method that check to see if a seession has already been created
        // 3. we will get session and store that in a string
        // 4. if that string is then not empty we will deserialize it and store it in a list <movies>

        private void PopulateFavorites()
        {
            string MovieListJson = HttpContext.Session.GetString("FavoriteMovies");
            if(MovieListJson != null)
            {
                userFavorites = JsonConvert.DeserializeObject<List<Movies>>(MovieListJson);
            }
        }
        
    }
}