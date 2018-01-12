using Avatar.Domain.Entities;
using Avatar.Infra.Data.Repository.Extensions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Infra.Data.Repository.Mapping
{
    public class SkillMap : EntityTypeConfiguration<Skill>
    {
        public override void Map(EntityTypeBuilder<Skill> builder)
        {
            builder.ToTable("SKILL");

            builder
                    .HasOne(x => x.User)
                    .WithMany(x => x.Skills);
        }
    }
}
