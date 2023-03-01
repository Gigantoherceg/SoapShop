using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SoapShop.BackEnd.Models
{
    public class SoapDbContext : IdentityUserContext<ApplicationUser>
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

        public SoapDbContext(DbContextOptions<SoapDbContext> options) : base(options)
        {
        }

    }
}
