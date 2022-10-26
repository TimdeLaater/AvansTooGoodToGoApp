using DomainModel.Models.Enum;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Models
{
    public class Product
    {
        public Product(int productId, string name, bool alcohol)
        {
            ProductId = productId;
            Name = name;
            Alcohol = alcohol;
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ProductId { get; set; } 
        public string Name { get; set; } 
        public Boolean Alcohol { get; set; }
        public List<Package_Product> Package_Product { get; set; }


    }
}
