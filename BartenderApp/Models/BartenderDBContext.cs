using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace BartenderApp.Models
{
    public class BartenderDbContext : DbContext
    {

        public DbSet<Order> Orders { get; set; }
        public DbSet<Drink> Drinks { get; set; }


    }
}
