using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace DomainModel.Models
{
    public class AppUser : IdentityUser
    {
       
        public string Name { get; set; }
        
    }
}