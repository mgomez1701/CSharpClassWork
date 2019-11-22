using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppRedo.Models
{
    public class UFCFighters
    {
        public string Name { get; set;}
        public string HomeTown { get; set; }
        public bool Champion { get; set; }
        public int Wins { get; set; }
        public string Age { get; set; }
        public List<MOV>MethodOfVictory { get; set; }

        public UFCFighters(string name, string homeTown, bool champion, int wins, string age,List<MOV>methodOfVictory)
        {
            Name = name;
            HomeTown = homeTown;
            Champion = champion;
            Wins = wins;
            Age = age;
            MethodOfVictory = methodOfVictory;

        }
    }
}
