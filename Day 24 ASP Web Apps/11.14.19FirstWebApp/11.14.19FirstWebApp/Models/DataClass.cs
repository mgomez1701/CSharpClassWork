using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _11._14._19FirstWebApp.Models
{
    public class DataClass
    {
        public static List<Powers> necessaryPowers = new List<Powers>
        {
            new Powers("Speed", 5000, "Really high velocity"), //0
            new Powers("Spider Sense", 5000, "Can tell when he is in danger"),
            new Powers("Wall crawling", 5000, "Can stick to walls"), //2
            new Powers("Super Intelligence", 5000, "Super Intelligent"), //3
            new Powers("Fighting Skills", 100, "Hero is great in hand to hand combat"), //4
            new Powers("Evil Spirit Ball", 100000, "Power blast that can destroy planets"), //5
            new Powers("Getting Buckets", 100, "Makes all of them"),//6
            new Powers("Power Zapping", 99, "Stealing the Essence of Athletes"),//7
            new Powers("Immortal",125000 , "He literally cannot die"),//8
            new Powers("Healing Factor", 9000, "regenerates damaged or destro,yed tissues of his body"),//9
            new Powers("AnimalInstincts", 4000, "Animal like Senses"),//10
            new Powers("Final Flash", 100000, "The Last thing you'll see"),//11
            new Powers("Speak to the Manager", 1000000, "She took the kids, now she wants your job"),//12
            new Powers("Mop Swinging", 10, "Dispatches drug dealers"),//13
            new Powers("Shape Shifter", 10000, "transforms into whatever"),//14
            new Powers("Scorching Caress",1000,"Manipulate super-heated objects"), //Cinder Fall (edited) 
            new Powers("Royal B*&@%",-1000,"Being a royal b*&@% that doesn't know when to die. Like a cockroach.")
        };
        public static List<Supers> superHeros = new List<Supers>
        {
            new Supers("Ruby Rose", "N/A", true, "RWBY", new List<Powers>{necessaryPowers[0]}),
            new Supers("Spiderman", "Peter Parker", true, "Marvel", new List<Powers>{necessaryPowers[1], necessaryPowers[2] }),
            new Supers("Kick-Ass", "Dave Lizewski", true,"N/A", new List<Powers>{necessaryPowers[4] }),
            new Supers("Michael Jordan", "GOAT", true, "NBA", new List<Powers>{necessaryPowers[6] }),
             new Supers("Dead-Pool", "Wade Wilson",true,"Marvel", new List<Powers>{necessaryPowers[8]}),
             new Supers("Wolverine", "Logan", true,  "DC", new List<Powers>(){ necessaryPowers[9]}),
             new Supers("Vegeta", "Vegeta", true, "Universe 6", new List<Powers>{necessaryPowers[11]}),
             new Supers("Toxic Avenger", "Melvin Ferd", true,"N/A", new List<Powers>{necessaryPowers[13] }),
        };
        public static List<Supers> superVillains = new List<Supers>
        {
            new Supers("Doctor Doom", "Victor Von Doom", false, "Marvel", new List<Powers>{necessaryPowers[3] }),
            new Supers("Frieza", "Frieza", false,  "Dragon Ball Z", new List<Powers>{necessaryPowers[5] }),
            new Supers("Aliens", "Monstars", false,  "Outer Space", new List<Powers>{ necessaryPowers[7] }),
            new Supers ("Thanos", "Thanos",false, "Marvel", new List<Powers>{  necessaryPowers[8]}),
            new Supers("Sabretooth", "Victor Creed", false, "DC", new List<Powers>(){ necessaryPowers[10]}),
            new Supers("Karen", "Karen Smith", false,  "This One", new List<Powers>{necessaryPowers[12]}),
            new Supers("Loki", "N/A", false,  "Marvel", new List<Powers>{necessaryPowers[14]}),
            new Supers("Cinder Fall","N/A", false,"RWBY",new List<Powers>{necessaryPowers[15], necessaryPowers[16]})
        };

        private static int CalculatePowers(List<Powers> powers)
        {
            int sum = 0;
            foreach (Powers power in powers)
            {
                sum += power.Level;
            }
            return sum;
        }

        public static void FillPowers(List<Supers> supers)
        {
            foreach (Supers super in supers)
            {
                if (super.Powers != null)
                {
                    super.PowerLevel = CalculatePowers(super.Powers);
                }
            }
        }
     

        
        

    }
}
