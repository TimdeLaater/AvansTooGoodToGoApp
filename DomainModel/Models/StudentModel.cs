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
        
        [Key]
        public string Email { get; set; }
        public string name { get; set; }
        enum Locations
        {
            Breda = 1,
            DenBosch,
            Tilburg,

        }
        private DateTime MinumAge = DateTime.Now.AddYears(-16);
        [Key]
        public int StudentNr { get; set; }
       

        [DataType(DataType.Date)]
        public string BirthDay { get; set; }
        public string PhoneNumber { get; set; }
        public int NotCollected { get; set; }   


 
    }
}
