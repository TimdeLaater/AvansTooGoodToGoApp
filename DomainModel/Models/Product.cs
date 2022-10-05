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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ProductId { get; set; } 
       public string Name { get; set; } 
        public Boolean Alcohol { get; set; }    
        public Photo Photo { get; set; }
        [FromForm]
        [NotMapped]
        public IFormFile File { get; set; }
    }
}
