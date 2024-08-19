using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ENTITIES
{
    public class Order
    {
        [Key]
        public int OrderNumber { get; set; }

        public string UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public ApplicationUser ApplcationUser { get; set; }

        public int Qunatity { get; set; }

        public decimal TotalPrice { get; set; }

    }
}
