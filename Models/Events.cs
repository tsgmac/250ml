using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _250ml.Models
{
    public class Events
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public DateTime startdate { get; set; }
        public DateTime enddate { get; set; }
        public int ratingSum { get; set; }
        public int ratingCount { get; set; }
        public List<Ratings> ratings { get; set; }
    }
}