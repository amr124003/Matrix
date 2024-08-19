using System.ComponentModel.DataAnnotations;

namespace Matrix.VM
{
    public class UserLogin
    {
        [Required]
        public string? Name { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        public bool RemeberMe { get; set; }
    }
}
