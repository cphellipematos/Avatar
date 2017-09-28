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
            builder.Property(x => x.Name)
                .HasColumnName("NAME");
            builder.Property(x => x.InsertDate)
                .HasColumnName("INSERT_DATE");
            builder.Property(x => x.UpdateDate)
                .HasColumnName("UPDATE_DATE");
            builder.Property(x => x.StartDate)
                .HasColumnName("START_DATE");
            builder.Property(x => x.EndDate)
                .HasColumnName("END_DATE");
        }
    }
}
