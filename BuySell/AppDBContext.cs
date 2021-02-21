using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BuySell
{
    public class AppDBContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
        public AppDBContext() : base("db")
        {

        }
    }
}