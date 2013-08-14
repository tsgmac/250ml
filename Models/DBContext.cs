using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace _250ml.Models
{
    public class DBContext : DbContext
    {
        public DbSet<Events> Eventlist { get; set; }
        public DbSet<Ratings> Ratinglist { get; set; }
    }
}