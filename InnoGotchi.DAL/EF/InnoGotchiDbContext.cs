using InnoGotchi.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace InnoGotchi.DAL.EF
{
    public sealed class InnoGotchiDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public InnoGotchiDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
