using Avatar.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Avatar.Infra.Data.Repository.Context
{
    public class AvatarContext : DbContext
    {

        public AvatarContext(DbContextOptions<AvatarContext> options) : base(options)
        {
        }
        public DbSet<User> User { get; set; }
        public DbSet<Category> Category { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("USERS");
            modelBuilder.Entity<Category>().ToTable("CATEGORY");
        }
    }
}
