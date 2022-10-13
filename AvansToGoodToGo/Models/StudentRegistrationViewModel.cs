using System.ComponentModel.DataAnnotations;

namespace AvansTooGoodToGo.Models
{
    public class StudentRegistrationViewModel
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int StudentNr { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateOnly BirthDay { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
