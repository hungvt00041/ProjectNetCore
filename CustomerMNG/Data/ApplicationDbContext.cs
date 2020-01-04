using System;
using System.Collections.Generic;
using System.Text;
using CustomerMNG.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CustomerMNG.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {   
        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Category { get; set; }

        public DbSet<Order> Order { get; set; }

        public DbSet<ProductOrder> ProductOrder { get; set; }
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

            modelBuilder.Entity<ProductOrder>().HasOne(x => x.Order)
                .WithMany(x => x.ProductOrders)
                .HasForeignKey(x => x.OrderId);

            modelBuilder.Entity<ProductOrder>().HasOne(x => x.Product)
                .WithMany(x => x.ProductOrders)
                .HasForeignKey(x => x.ProductId);
            modelBuilder.Entity<ProductOrder>().HasKey(to => new { to.OrderId, to.ProductId });
        }
    }
}
