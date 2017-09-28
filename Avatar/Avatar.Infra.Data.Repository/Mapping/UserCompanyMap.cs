using Avatar.Domain.Entities;
using Avatar.Infra.Data.Repository.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Avatar.Infra.Data.Repository.Mapping
{
    public class UserCompanyMap : EntityTypeConfiguration<UserCompany>
    {
        public override void Map(EntityTypeBuilder<UserCompany> builder)
        {
            builder.ToTable("USER_COMPANY");
                                         
            builder                
                .HasOne(x => x.Company)
                .WithMany(x => x.UserCompany);

            builder
                .HasOne(x => x.User)
                .WithMany(x => x.UserCompanies);
            
                
        }
    }
}
