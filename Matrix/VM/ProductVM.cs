using System.ComponentModel.DataAnnotations;

namespace Matrix.VM
{
    public class ProductVM
    {
        [Required]
        [MaxLength(30)]
        [MinLength(5)]
        public string? Name { get; set; }

        [Required]
        [DataType(DataType.ImageUrl)]
        public string? Image { get; set; }

        [Required]
        [Range(200, 100000, ErrorMessage = "The Product Price Must Be Between 200 EGP And 100000 EGP")]
        public decimal Price { get; set; }

        [Required]
        [RegularExpression("(Phones|Cameras|HeadPhones|Laptops)")]
        public string? Section { get; set; }

    }
}
