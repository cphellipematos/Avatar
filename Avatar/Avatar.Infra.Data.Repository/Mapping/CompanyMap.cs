using Avatar.Domain.Entities;
using Avatar.Infra.Data.Repository.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Avatar.Infra.Data.Repository.Mapping
{
    public class CompanyMap : EntityTypeConfiguration<Company>
    {
        public override void Map(EntityTypeBuilder<Company> builder)
        {
            builder.ToTable("COMPANY");

            builder.Property(x => x.DurationTypeId)
                .HasColumnName("IdDurationType");
            builder.Property(x => x.UserId)
                .HasColumnName("IdUser");

            builder
                .HasOne(x => x.User)
                .WithMany(x => x.Companies);
        }
    }
}
