using DomainModel.Models;
using DomainModel.Models.Enum;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class FoodDBContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Package> Packages { get; set; }  
        public DbSet<Package_Product> package_Products { get; set; }
        public FoodDBContext(DbContextOptions<FoodDBContext> options) : base(options)
        {
            
        }

        protected override async void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Package_Product>()
                .HasOne(p => p.Product)
                .WithMany(pp => pp.Package_Product)
                .HasForeignKey(p => p.ProductId);

            modelBuilder.Entity<Package_Product>()
                .HasOne(p => p.Package)
                .WithMany(pp => pp.Package_Product)
                .HasForeignKey(p => p.PackageId);



            //Seeden
            Canteen[] canteens = new Canteen[]
            {
                new Canteen(44, "LA", City.Breda, true),
                new Canteen(45, "LD", City.Breda, true),
                new Canteen(46, "HA", City.Breda, true),
                new Canteen(47, "HA", City.Tilburg, true),
                new Canteen(48, "HA", City.DenBosch, true)
            };


            
            Product[] products = new Product[]
            {
                new Product(69, "KaasoufleeBitch", false ),
                new Product(99, "Brie", false ),
            };
            
            
            modelBuilder.Entity<Canteen>().HasData(canteens);
            
            modelBuilder.Entity<Product>().HasData(products);
            





        }

        public FoodDBContext()
        {

        }

    }
}
