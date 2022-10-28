using DomainModel.Models.Enum;
using System.ComponentModel.DataAnnotations;

namespace AvansTooGoodToGo.Models
{
    public class RegisterStudentViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public City City { get; set; }
        [Required]

        public int StudentNr { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public string BirthDay { get; set; }

    }
}
