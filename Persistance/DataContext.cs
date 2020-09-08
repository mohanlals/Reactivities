using System;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistance
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder builder) 
        {
             builder.Entity<Value>().HasData(
new Value { Id = 1, Name = "Mohanlal 1" },
new Value { Id = 2, Name = "Mohanlal 2" },
new Value { Id = 3, Name = "Mohanlal 3" }
          );
        }
          //base.OnModelCreating(modelBuilder);
         
        public DbSet<Value> values{get;set;}
      
    }
}
