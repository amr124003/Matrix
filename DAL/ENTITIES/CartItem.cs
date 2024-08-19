using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ENTITIES
{
    public class CartItem
    {
        public int Id { get; set; }

        public int ProId { get; set; }

        public ApplicationUser? ApplcationUser { get; set; }

        public string UserId { get; set; }

        public Product Products { get; set; }
        public string Name { get; set; }
        public string Section { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public List<Order> Orders { get; set; }

    }
}
