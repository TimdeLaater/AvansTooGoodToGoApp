using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Models
{
    internal class StudentModel
    {
        [Required(ErrorMessage = "Voer uw Email in")]
        [DataType(DataType.EmailAddress)]
        [Key]
        public string email { get; set; }
        [Required(ErrorMessage = "Voer uw naam in"), MaxLength(255)]
        public string name { get; set; }
        enum Locations
        {
            Breda = 1,
            DenBosch,
            Tilburg,

        }
        private DateTime minumAge = DateTime.Now.AddYears(-16);

        public int studentNr { get; set; }
       

        [DataType(DataType.Date)]
        public string birthDay { get; set; }
        public string phoneNumber { get; set; }
        public int notCollected { get; set; }   


 
    }
}
