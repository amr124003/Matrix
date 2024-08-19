using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ENTITIES
{
    public class ApplicationUser : IdentityUser
    {
        public string Address { get; set; }


        public List<CartItem>? cartItems { get; set; }

        public Order? Order { get; set; }

        public string PhoneNumber { get; set; }

        public string? Country { get; set; }

    }
}
