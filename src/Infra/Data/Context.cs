using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> opt) : base(opt) { }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<SystemRole> SystemRoles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
