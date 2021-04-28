using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Models.Identity;

namespace WebApplication1.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, int>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Category>()
                .HasData(
                new Category { Id = 1, Name = "Big Cats" },
                new Category { Id = 3, Name = "Aquatic/Fish"},
                new Category { Id = 4, Name = "Arachnids"},
                new Category { Id = 5, Name = "Reptiles"}
            );

            builder.Entity<Product>()
                .HasData(
                 new Product { Id = 1, Name = "Kratos the Tiger" },
                 new Product { Id = 3, Name = "Dory the fsh" },
                 new Product { Id = 4, Name = "Lucas the spider" },
                 new Product { Id = 5, Name = "Frogger the Frogg" }
                );

        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}
