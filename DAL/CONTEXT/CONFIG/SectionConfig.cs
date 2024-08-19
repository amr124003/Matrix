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
    public class SectionConfig : IEntityTypeConfiguration<Sections>
    {
        public void Configure(EntityTypeBuilder<Sections> builder)
        {

            builder.HasMany(x => x.Staffs)
                   .WithMany(x => x.sections)
                   .UsingEntity<SectionStaff>
               (
                 x =>
                 {
                     x.HasOne(x => x.Sections)
                     .WithMany(x => x.secstaff)
                     .HasForeignKey(x => x.SectionName)
                     .HasPrincipalKey(x => x.Name);

                     x.HasOne(x => x.Staff)
                     .WithMany(x => x.staffs)
                     .HasForeignKey(x => x.EmpName)
                     .HasPrincipalKey(x => x.Name);

                     x.HasKey(x => x.Id);

                     x.Ignore(x => x.Mangers);
                 }
               );
        }
    }
}
