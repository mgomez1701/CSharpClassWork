﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPICatEx.Models
{

    public class CatRoot
    {
        public Cats[] Property1 { get; set; }
    }

    public class Cat
    {
        public object[] breeds { get; set; }
        //public Category[] categories { get; set; }
        public string id { get; set; }
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    //public class Category
    //{
    //    public int id { get; set; }
    //    public string name { get; set; }
    //}

}
