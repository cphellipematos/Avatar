using Avatar.Domain.Entities;
using Avatar.Infra.Data.Repository.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Avatar.Infra.Data.Repository.Mapping
{
    public class UserCourseMap : EntityTypeConfiguration<UserCourse>
    {
        public override void Map(EntityTypeBuilder<UserCourse> builder)
        {
            builder.ToTable("USERS_COURSE");

            builder.Property(x => x.IdCourse)
                .HasColumnName("ID_COURSE");
            builder.Property(x => x.IdUser)
                .HasColumnName("ID_USERS");

        }
    }
}
