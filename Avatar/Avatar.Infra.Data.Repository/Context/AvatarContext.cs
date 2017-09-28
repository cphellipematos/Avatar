using Avatar.Domain.Entities;
using Avatar.Infra.Data.Repository.Extensions;
using Avatar.Infra.Data.Repository.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Avatar.Infra.Data.Repository.Context
{
    public class AvatarContext : DbContext
    {
        public AvatarContext()            
        {

        }
        public DbSet<User> User { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<UserCompany> UserCompany { get; set; }
        public DbSet<Company> Company { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {            
            modelBuilder.AddConfiguration(new UserCompanyMap());
            modelBuilder.AddConfiguration(new UserMap());
            modelBuilder.AddConfiguration(new CategoryMap());
            modelBuilder.AddConfiguration(new CompanyMap());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // get the configuration from the app settings
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            // define the database to use
            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
        }
    }
}
