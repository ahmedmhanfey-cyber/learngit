using EntityTask.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
//Implement **One-to-One** (`Product` <=> `ProductDetail`), **One-to-Many** (`Category` <=>  `Product`, `Customer` <=>  `Order`)
namespace EntityTask
{
    internal class ShopDBcontext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=AHMEDHANF\\SQLEXPRESS;Integrated Security=True ;database=shop;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Application Name=\"SQL Server Management Studio\";Command Timeout=0");
        }
        public DbSet<Product> products { get; set; }
        public DbSet<Productdetails> productdetails { get; set; }
        public DbSet<category> categories { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<OrderItem> orderItems { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderItem>()
                .HasKey(o => new { o.orderId, o.productId });
            modelBuilder.Entity<OrderItem>()
                .HasOne(o => o.Product)
                .WithMany(o => o.OrderItems)
                .HasForeignKey(o => o.productId);
            modelBuilder.Entity<OrderItem>()
                  .HasOne(o => o.order)
                  .WithMany(o => o.orderItems)
                  .HasForeignKey(o => o.orderId);

            modelBuilder.Entity<Product>()
                .HasOne(p => p.productdetail)
                .WithOne(pd => pd.product)
                .HasForeignKey<Productdetails>(pd => pd.productId);
            modelBuilder.Entity<Order>()
                .HasOne(o => o.customer)
                .WithMany(c => c.orders)
                .HasForeignKey(o => o.customerId);



        }
    }
    }

