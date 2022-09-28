using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Models
{
    public class Product
    {
        public int productId { get; set; } 
       public string Name { get; set; } 
        public Boolean alcohol { get; set; }    
        public string picture { get; set; } 
    }
}
