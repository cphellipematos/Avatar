using Avatar.Domain.Entities;
using Avatar.Infra.Data.Repository.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Avatar.Infra.Data.Repository.Mapping
{
    public class CourseMap : EntityTypeConfiguration<Course>
    {
        public override void Map(EntityTypeBuilder<Course> builder)
        {
            builder.ToTable("COURSE");

            builder.Property(x => x.DurationTypeID)
                .HasColumnName("IdDurationType");

            builder.Property(x => x.UserId)
                .HasColumnName("IdUser");

            builder
                .HasOne(x => x.User)
                .WithMany(x=>x.Courses);
                
        }
    }
}
