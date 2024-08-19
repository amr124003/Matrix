using DAL.CONTEXT;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ENTITIES
{
    public class Product
    {

        public Product()
        {
            Status = "New";
            ApplicationDBcontext context = new();
            Id = context.Products.Max(x => x.Id) + 1;
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        [MinLength(5)]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.ImageUrl)]
        public string Image { get; set; }

        [Required]
        [Range(200, 100000, ErrorMessage = "The Product Price Must Be Between 200 EGP And 100000 EGP")]
        public decimal Price { get; set; }

        public string? Status { get; set; }

        [Required]
        [RegularExpression("(Phones|Cameras|HeadPhones|Laptops)")]
        public string Section { get; set; }


        public string? SelectedColor { get; set; }

        public virtual List<CartItem> cartItem { get; set; }


    }
}
