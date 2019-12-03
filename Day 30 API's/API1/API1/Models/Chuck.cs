using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API1.Models
{

    public class Chuck
    {
        public string type { get; set; }
        public Value value { get; set; }
    }

    public class Value
    {
        public int id { get; set; }
        public string joke { get; set; }
        public object[] categories { get; set; }
    }





}
