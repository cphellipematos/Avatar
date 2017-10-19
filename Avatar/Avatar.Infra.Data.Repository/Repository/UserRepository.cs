using Avatar.Domain.Entities;
using Avatar.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using Avatar.Infra.Data.Repository.Context;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Avatar.Infra.Data.Repository.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(AvatarContext context)
            : base(context)
        {
        }

        
        public IEnumerable<User> GetAllUserCompaniesByUserId(int userId)
        {
            var userCompanies =
                Db.User
                .Where(x => x.Id == userId)
                .Include(c => c.Companies).ToList();

            userCompanies = userCompanies ?? default(List<User>);

            return userCompanies;
        }

        public IEnumerable<User> GetAllUserCoursesByUserId(int userId)
        {
            var userCourses =
                Db.User
                .Where(x => x.Id == userId)
                .Include(c => c.Courses).ToList();

            userCourses = userCourses ?? default(List<User>);

            return userCourses;
        }

        public User GetUserByEmail(string email)
        {
            var user =
                Db.User
                .Where(x => x.Email == email)
                .FirstOrDefault();
           
            return user;
        }


    }
}
