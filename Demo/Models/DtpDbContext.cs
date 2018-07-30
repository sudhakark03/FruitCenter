using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Demo.Models
{
    public class DtpDbContext : DbContext
    {
        public DtpDbContext()
            : base("DefaultConnection")
        {
        }

        
        public DbSet<Fruit> FruitTable { get; set; }
        public DbSet<USER> USER { get; set; }
    }
}