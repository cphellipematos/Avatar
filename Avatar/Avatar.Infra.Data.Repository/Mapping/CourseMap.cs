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
                .HasColumnName("ID_DURATION_TYPE");
            builder.Property(x => x.Name)
                .HasColumnName("NAME");
            builder.Property(x => x.Company)
                .HasColumnName("COMPANY");
            builder.Property(x => x.Description)
                .HasColumnName("DESCRIPTION");
            builder.Property(x => x.StartDate)
                .HasColumnName("START_DATE");
            builder.Property(x => x.EndDate)
                .HasColumnName("END_DATE");
            builder.Property(x => x.InsertDate)
                .HasColumnName("INSERT_DATE");
            builder.Property(x => x.UpdateDate)
                .HasColumnName("UPDATE_DATE");
        }
    }
}
