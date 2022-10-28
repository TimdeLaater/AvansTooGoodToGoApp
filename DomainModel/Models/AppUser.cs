using Microsoft.AspNetCore.Identity;

namespace DomainModel.Models
{
    public class AppUser : IdentityUser
    {
        public string Name { get; set; }
        public string Phonenumber { get; set; }
    }
}