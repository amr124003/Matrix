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
    public class OrderConfig : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasOne(x => x.ApplcationUser)
                   .WithOne(x => x.Order)
                   .HasForeignKey<Order>(x => x.UserId)
                   .HasPrincipalKey<ApplicationUser>(x => x.Id);
        }
    }
}
