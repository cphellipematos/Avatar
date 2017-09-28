using Avatar.Domain.Entities;
using Avatar.Infra.Data.Repository.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Avatar.Infra.Data.Repository.Mapping
{
    public class CategoryMap : EntityTypeConfiguration<Category>
    {
        public override void Map(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("CATEGORY");
        }
    }
}
