using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BartenderApp.Models
{
    public class Order
    {
        public int Id { get; set; }
        public Drink Drink { get; set; }
    }
    public class OrderDbContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }

    }
}