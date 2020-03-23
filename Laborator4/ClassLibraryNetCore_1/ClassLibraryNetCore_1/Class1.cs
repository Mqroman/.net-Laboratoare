using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.Configuration;

namespace ClassLibraryNetCore.Model
{
    public partial class Client
    {
        public int ClientId { get; set; }
        [MaxLength(20)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        // 0 = inregistrare corecta; 1 = inregistrare stearsa
        //public int Deleted { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<Client> Clients { get; set; }

        protected Client() { }
    }
    public partial class Order
    {
        public int OrderId { get; set; }
        [MaxLength(20)]
        public DataType Date { get; set; }
        public int Value { get; set; }
        public int Payed { get; set; }

        public int Clientid { get; set; }



        // 0 = inregistrare corecta; 1 = inregistrare stearsa
        public int Deleted { get; set; }
        public ICollection<Order> Client { get; set; }
        public ICollection<OrderDetails> OrderDetails { get; set; }


        protected Order() { }
    }

    public partial class OrderDetails
    {
        public int OrderDetailId { get; set; }
        [MaxLength(20)]
        public int ProductId { get; set; }
        public int Qty { get; set; }
        public int Price { get; set; }

        public int Orderid { get; set; }



        // 0 = inregistrare corecta; 1 = inregistrare stearsa
        public int Deleted { get; set; }
        public ICollection<Order> Orders { get; set; }

        protected OrderDetails() { }
    }

    public partial class Product
    {
        public int ProductId { get; set; }
        [MaxLength(20)]
        public string ProductName { get; set; }
        public int Stock { get; set; }
        public int Price { get; set; }

        public int OrderDetailsId { get; set; }



        // 0 = inregistrare corecta; 1 = inregistrare stearsa
        public int Deleted { get; set; }
        public ICollection<OrderDetails> OrderDetails { get; set; }

        protected Product() { }
    }
    internal class ModelContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-NC8L2CK; Database = EFCore2020; Trusted_Connection = True");
        //ChangeTracker.LazyLoadingEnabled = false;
 }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
            .HasMany<Order>(o => o.Orders)
            .WithOne(c => c.Client);

            modelBuilder.Entity<OrderDetails>()
            .HasOne<Order>(od => od.Order)
            .WithMany(o => o.OrderDetails);
            modelBuilder.Entity<Product>()
            .HasMany<OrderDetails>(p => p.OrderDetails)
            .WithOne(od => od.Product);
        }
    }

   

    
}