using Avatar.Domain.Entities;
using Avatar.Infra.Data.Repository.Extensions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Avatar.Infra.Data.Repository.Mapping
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public override void Map(EntityTypeBuilder<User> builder)
        {
            builder
                .ToTable("USER");

            

            builder
                .HasMany(x => x.Companies)
                .WithOne(x => x.User);

            builder
                .HasMany(x => x.Courses)
                .WithOne(x => x.User);

            builder
                .HasMany(x => x.Skills)
                .WithOne(x => x.User);

        }
    }
}
