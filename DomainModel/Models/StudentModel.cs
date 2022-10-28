using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using DomainModel.Models.Enum;
using Microsoft.AspNetCore.Identity;

namespace DomainModel.Models
{

    public class StudentModel 
    {
        [Key]
        public int StudentId { get; set; }
        public string Name { get; set; }
        public City City { get; set; }  
        public int StudentNr { get; set; }
        public string BirthDay { get; set; }
        public int NotCollected { get; set; }

        [ForeignKey("AppUser")]
        public string AppUserId { get; set; }
        public AppUser User;

    }
}
