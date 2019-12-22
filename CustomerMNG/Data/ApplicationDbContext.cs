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
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
