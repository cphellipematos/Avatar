using Avatar.Domain.Entities;
using Avatar.Infra.Data.Repository.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Avatar.Infra.Data.Repository.Mapping
{
    public class DurationTypeMap : EntityTypeConfiguration<DurationType>
    {
        public override void Map(EntityTypeBuilder<DurationType> builder)
        {
            builder.ToTable("DURATIONTYPE");

            
        }
    }
}
