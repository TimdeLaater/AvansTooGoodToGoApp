using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Models
{
    public class StudentModel : IdentityUser
    {
        [DatabaseGenerated]
        public int Id { get; set; } 
        [Key]
        public string Email { get; set; }
        public string Name { get; set; }
        
        [Key]
        public int StudentNr { get; set; }
       
        public string Password { get; set; }    
        public DateOnly BirthDay { get; set; }
        public string PhoneNumber { get; set; }
        public int? NotCollected { get; set; }   


 
    }
}
