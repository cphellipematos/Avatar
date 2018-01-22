using Avatar.Domain.Entities;
using Avatar.Infra.Data.Repository.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Avatar.Infra.Data.Repository.Mapping
{
    public class ContactMap : EntityTypeConfiguration<Contact>
    {
        public override void Map(EntityTypeBuilder<Contact> builder)
        {
            builder.ToTable("CONTACT");

            builder.Property(x => x.UserId)
                .HasColumnName("IdUser");

            builder
                .HasOne(x => x.User)
                .WithMany(x => x.Contacts);
        }
    }
}
