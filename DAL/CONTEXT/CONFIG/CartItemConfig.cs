using DAL.ENTITIES;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.CONTEXT.CONFIG
{
    public class Cartitemconfig : IEntityTypeConfiguration<CartItem>
    {
        public void Configure(EntityTypeBuilder<CartItem> builder)
        {

            builder.HasKey(x => x.Id);
            builder.ToTable("CartItems");


            builder.HasOne(x => x.Products)
                   .WithMany(x => x.cartItem)
                   .HasForeignKey(x => x.ProId)
                   .HasPrincipalKey(x => x.Id);


            builder.HasOne(x => x.ApplcationUser)
                   .WithMany(x => x.cartItems)
                   .HasForeignKey(x => x.UserId)
                   .HasPrincipalKey(x => x.Id);
        }
    }
}
