using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Models
{
   
    public class StudentModel
    {
        
        [Key]
        public string Email { get; set; }
        public string name { get; set; }
        public City City { get; set; }  
        public int StudentNr { get; set; }
        public string BirthDay { get; set; }
        public string PhoneNumber { get; set; }
        public int NotCollected { get; set; }   


 
    }
}
