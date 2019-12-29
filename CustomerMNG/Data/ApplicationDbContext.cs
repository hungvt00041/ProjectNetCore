using System;
using System.Collections.Generic;
using System.Text;
using CustomerMNG.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CustomerMNG.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {   
        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Category { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasOne(x => x.Category)
                .WithMany(x => x.Products)
                .HasForeignKey(x=>x.CategoryId);
            modelBuilder.Entity<Category>().HasData(new Category { Id = Guid.NewGuid(), Name = "Car" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = Guid.NewGuid(), Name = "Shoes" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = Guid.NewGuid(), Name = "Bike" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = Guid.NewGuid(), Name = "Computer" });
        }
    }
}
