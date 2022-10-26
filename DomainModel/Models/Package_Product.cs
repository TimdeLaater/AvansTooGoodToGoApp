using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Models
{
    public class Package_Product
    {
        public Package_Product(int productId, Product product, int packageId)
        {
            ProductId = productId;
            Product = product;
            PackageId = packageId;
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int ProductId { get; set; }
        public  Product Product { get; set; }
        public int PackageId { get; set; }  
        public Package? Package { get; set; }    

    }
}
