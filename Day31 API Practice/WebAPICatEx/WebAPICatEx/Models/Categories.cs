using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPICatEx.Models
{
    //step 2 create a class
    //step 3 get rid of class
    // step 4 paste special in Edit json as class 

    public class Categories
    {
        public Cats[] Property1 { get; set; }
    }

    public class Cats
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    //step 5 call API in new created "cat" controller 
}
