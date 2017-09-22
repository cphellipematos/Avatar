using Avatar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Domain.Interfaces.Services
{
    public interface IUserService
    {
        void CreateUser();
        void DeleteUser(int id);
        void GetUserById(int id);
        IEnumerable<User> GetAllUsers();
        void UpdateUser();
    }
}
