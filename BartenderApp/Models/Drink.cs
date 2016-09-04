using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BartenderApp.Models
{
    public class Drink
    {
        public int Id { get; set; }
        public string Name { get; set; }

        
    }

    public class DrinkDbContext : DbContext
    {
        public DbSet<Drink> Drinks { get; set; }    

           
    }
}