using Avatar.Domain.Entities;
using Avatar.Infra.Data.Repository.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Avatar.Infra.Data.Repository.Mapping
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public override void Map(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("USERS");
        }
    }
}
