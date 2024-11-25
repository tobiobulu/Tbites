using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tbites.Models;

namespace Tbites.Data
{
    public class TbitesContext : DbContext
    {
        public TbitesContext (DbContextOptions<TbitesContext> options)
            : base(options)
        {
        }

        public DbSet<FoodItem> FoodItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FoodItem>().ToTable("FoodItems");
        }
    

    public DbSet<Tbites.Models.FoodItem> FoodItem { get; set; } = default!;
    }
}

