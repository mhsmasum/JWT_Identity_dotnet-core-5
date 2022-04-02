using ApplicationDemo.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationDemo.Data
{
    public class ApplicationDBContex : IdentityDbContext

    {
        public ApplicationDBContex(DbContextOptions<ApplicationDBContex> options):base   (options)
        {
                
        }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Order2> Order2s { get; set; }
        public DbSet<OrderItem2> OrderItem2 { get; set; }
        public DbSet<OderItem> OderItems { get; set; }

        public DbSet<Order3> Order3 { get; set; }
        public DbSet<Order3Detail> Order3Details { get; set; }
    }
}
