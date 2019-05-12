using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebDictionary.Models
{
    public class DriverContext : DbContext
    {
        public DriverContext() : base("DriverContext")
        {
        }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Car> Cars { get; set; }
    }
}