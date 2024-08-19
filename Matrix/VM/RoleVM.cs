using System.ComponentModel.DataAnnotations;

namespace Matrix.VM
{
    public class RoleVM
    {
        [Required]
        public string? Name { get; set; }
    }
}
