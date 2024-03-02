﻿using AituFood.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AituFood.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categorys { get; set; }    
        public DbSet<Cart> Carts { get; set; }    
        public DbSet<Order> Orders { get; set; }    

        public DbSet<CartDetail> CartDetails { get; set; }    
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }
        public List<OrderDetail> OrderDetail { get; set; }

    }
}