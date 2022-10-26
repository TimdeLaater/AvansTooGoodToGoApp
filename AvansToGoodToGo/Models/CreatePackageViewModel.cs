using DomainModel.Models.Enum;
using DomainModel.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AvansTooGoodToGo.ViewModels
{
    public class CreatePackageViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public Boolean Alcohol { get; set; } //TODO: Look up if items contains a 18+ item for this Boolean.
        [Required]
        public int Price { get; set; }
        public DateTime orderPickup { get; set; }
        public MealType MealType { get; set; }

        
        public List<int>? ProductIds { get; set; }
    }
}
