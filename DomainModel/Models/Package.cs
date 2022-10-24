using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Models
{
    public class Package
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PackageId { get; set; }  
        public string Name { get; set; }
        public ICollection<Product>? ProductList {get; set;}
        public Canteen? Canteen { get; set;}
        public Boolean Alcohol { get; set;} //TODO: Look up if items contains a 18+ item for this Boolean.
        public int Price { get; set;}
        [ForeignKey("StudentModel")]
        public string? StudentId { get; set;}    //TODO: Needs to be linked to the student who reserved the Package.
        public StudentModel? Student { get; set; }
        public DateTime orderPickup { get; set;}   
        public Boolean collected { get; set;}

    }
}
