using System.ComponentModel.DataAnnotations;

namespace Matrix.VM
{
    public class UserVM
    {
        [Required]
        [MaxLength(20)]
        [MinLength(3)]
        public string? Name { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
        [Required]
        public string? PhoneNumber { get; set; }
        [Required]
        [RegularExpression(@"^[A-Z]{5,20}-[A-Z]{5,20}-[A-Z]{5,20}")]
        public string? Address { get; set; }
        [Required]
        public string? Country { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
        [Required]
        [Compare("Password", ErrorMessage = "Not Matching Passwords")]
        [DataType(DataType.Password)]
        public string? ConfirmPassword { get; set; }
        [Required]
        public bool Agree { get; set; }
    }
}
