using Avatar.Domain.Entities;
using Avatar.Domain.Interfaces.Repository;
using Avatar.Infra.Data.Repository.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Infra.Data.Repository.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(AvatarContext context)
            :base(context)
        {

        }
    }
}
