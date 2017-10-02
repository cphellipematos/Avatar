using Avatar.Domain.Entities;
using Avatar.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using Avatar.Infra.Data.Repository.Context;

namespace Avatar.Infra.Data.Repository.Repository
{
    public class DurationTypeRepository : Repository<DurationType>, IDurationTypeRepository
    {
        public DurationTypeRepository(AvatarContext context) 
            : base(context)
        {
        }
    }
}
