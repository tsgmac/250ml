using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _250ml.Models
{
    public class Ratings
    {
        public int ID { get; set; }
        public int rating { get; set; }
        public String comment { get; set; }
        public String username { get; set; }
        public Events eventname { get; set; }
    }
}