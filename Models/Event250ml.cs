using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace _250ml.Models
{
    public class Event250ml
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public DateTime startdate { get; set; }
        public DateTime enddate { get; set; }
    }

    public class Event250mlDBContext : DbContext
    {
        public DbSet<Event250ml> Events250ml { get; set; }
    }
}