using DomainModel.Models;
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
        public FoodDBContext(DbContextOptions<FoodDBContext> options) : base(options)
        {
            
        }
        public FoodDBContext()
        {

        }

    }
}
