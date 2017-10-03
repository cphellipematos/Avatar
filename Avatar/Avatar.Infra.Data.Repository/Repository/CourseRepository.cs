using Avatar.Domain.Entities;
using Avatar.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using Avatar.Infra.Data.Repository.Context;

namespace Avatar.Infra.Data.Repository.Repository
{
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        public CourseRepository(AvatarContext context) 
            : base(context)
        {
        }
    }
}
