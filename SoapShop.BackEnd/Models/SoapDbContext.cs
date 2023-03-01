using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SoapShop.BackEnd.Models
{
    public class SoapDbContext : IdentityUserContext<ApplicationUser>
    {
        public SoapDbContext(DbContextOptions<SoapDbContext> options) : base(options)
        {
        }
    }
}
