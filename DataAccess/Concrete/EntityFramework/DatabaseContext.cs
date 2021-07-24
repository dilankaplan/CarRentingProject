using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.EntityFramework
{
    public class DatabaseContext : DbContext
    {
      
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            DbContextOptionsBuilder dbContextOptionsBuilder = optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=RentACarProject;Trusted_Connection=true");

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<User> Users { get; set; }


    }
}
