using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Pierre.Models
{
    public class PierreContext : DbContext
    {
        public virtual DbSet<Flavor> Flavors {get;set;}
        public DbSet<Treat> Treats {get;set;}
        // public DbSet<FlavorTreat> FlavorTreat { get; set; }
        public PierreContext(DbContextOptions options) : base(options) {}
    }
}

// IdentityDbContext<ApplicationUser>