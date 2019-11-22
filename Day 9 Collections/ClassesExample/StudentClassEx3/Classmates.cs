using System;
using System.Collections.Generic;
using System.Text;

namespace StudentClassEx3
{
    class Classmates
    {
        #region field
        private string name;
        private string homeTown;
        private string favoriteFood;
        private string favoriteHobby;
        private double favoriteNumber;
        #endregion

        #region properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
            
        public string HomeTown
        {
            get { return homeTown; }
            set { homeTown = value; }
        }
        public string FavoriteHobby
        {
            get { return favoriteHobby; }
            set { favoriteHobby = value; }

        }

        public string FavoriteFood
        {
            get { return favoriteFood; }
            set { favoriteFood = value; }

        }
        public double FavoriteNumber
        {
            get { return favoriteNumber; }
            set { favoriteNumber = value; }

        }
        #endregion

        public Classmates()
        {

        }
        public Classmates(string _name, string _hometown, string _favoritefood, string _favoritehobby, double _favoritenumber)
        {
            name = _name;
            homeTown = _hometown;
            favoriteFood = _favoritefood;
            favoriteHobby = _favoritehobby;
            favoriteNumber = _favoritenumber;

        }


        public void PrintInfo()
        {
            Console.WriteLine("Classmate: " + Name);
            Console.WriteLine($"Classmates: {homeTown}");
            Console.WriteLine($"Classmates: {favoriteFood}");
            Console.WriteLine($"Classmates: {favoriteHobby}");
            Console.WriteLine($"Classmates: {favoriteNumber}");
            // go to the program and create class mates now

        }

    }
}
