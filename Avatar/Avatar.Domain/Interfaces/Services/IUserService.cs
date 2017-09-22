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
        void GetAllUsers();
        void UpdateUser();
    }
}
