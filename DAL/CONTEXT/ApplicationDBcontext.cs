using DAL.ENTITIES;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DAL.CONTEXT
{
    public class ApplicationDBcontext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDBcontext():base()
        {
            
        }
        public ApplicationDBcontext(DbContextOptions options):base(options) 
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            ConfigurationBuilder config = new();

            optionsBuilder.UseSqlServer("Data Source = .; Initial Catalog = Matrix ; Integrated Security = SSPI; TrustServerCertificate = True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDBcontext).Assembly);

            modelBuilder.Entity<IdentityUserLogin<string>>()
                .HasKey(x => x.UserId);

            modelBuilder.Entity<IdentityUserRole<string>>()
                .HasKey(x => new { x.RoleId, x.UserId });

            modelBuilder.Entity<IdentityUserToken<string>>()
                .HasKey(x => x.UserId);
        }

        public DbSet<Order> orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Staff> staffs { get; set; }
        public DbSet<SectionStaff> sectionStaffs { get; set; }
        public DbSet<Sections> sections { get; set; }
        public DbSet<CartItem> cartItems { get; set; }
    }
}
