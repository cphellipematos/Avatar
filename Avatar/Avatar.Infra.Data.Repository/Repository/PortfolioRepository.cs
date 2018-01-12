using Avatar.Domain.Entities;
using Avatar.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using Avatar.Infra.Data.Repository.Context;

namespace Avatar.Infra.Data.Repository.Repository
{
    public class PortfolioRepository : Repository<Portfolio>, IPortfolioRepository
    {
        public PortfolioRepository(AvatarContext context) 
            : base(context)
        {
        }
    }
}
