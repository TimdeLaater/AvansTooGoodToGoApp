using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Models
{
    internal class Package
    {
        public int packageId { get; set; }  
        public string name { get; set; }
        public ICollection<Product>? items {get; set;}
        public Canteen canteen { get; set;}
        public Boolean alcohol { get; set;} //TODO: Look up if items contains a 18+ item for this Boolean.
        public int price { get; set;}   
        public string? studentnr { get; set;}    //TODO: Needs to be linked to the student who reserved the Package.

        public DateTime orderPickup { get; set;}   
        public Boolean collected { get; set;}

    }
}
