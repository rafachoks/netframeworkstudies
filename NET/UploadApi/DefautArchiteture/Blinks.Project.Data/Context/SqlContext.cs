using Blinks.Project.Data.Mapping;
using Blinks.Project.Domain;
using Microsoft.EntityFrameworkCore;

namespace Blinks.Project.Data.Context
{
    public class SqlContext : DbContext
    {
        public SqlContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Midia> Midias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(new UserMap().Configure);
            modelBuilder.Entity<Midia>(new MidiaMap().Configure);
        }
    }
}
