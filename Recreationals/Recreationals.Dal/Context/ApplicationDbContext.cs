using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Recreationals.Dal.Entities;

namespace Recreationals.Dal.Context
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Sport> Sports { get; set; }
        public DbSet<SportsCenter> SportsCenters { get; set; }
        public DbSet<Field> Fields { get; set; }
        public DbSet<Term> Terms { get; set; }
        public DbSet<Profile> Profiles { get; set; }
    }
}
