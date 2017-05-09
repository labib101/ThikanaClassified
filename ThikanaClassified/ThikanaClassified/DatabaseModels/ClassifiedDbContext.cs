using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ThikanaClassified.DatabaseModels
{
    public class ClassifiedDbContext : DbContext
    {
        public DbSet<Authentication> Authentication { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ItemDB> Items { get; set; }
    }
}