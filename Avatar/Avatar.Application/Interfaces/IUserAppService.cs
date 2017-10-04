using Avatar.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Application.Interfaces
{
    public interface IUserAppService
    {
        void CreateUser(UserViewModel user);
        void DeleteUser(int id);
        UserViewModel GetUserById(int id);
        IEnumerable<UserViewModel> GetAllUsers();
        IEnumerable<UserViewModel> GetAllUserCompaniesByUserId(int userId);
        IEnumerable<UserViewModel> GetAllUserCoursesByUserId(int userId);
        UserViewModel UpdateUser(UserViewModel user);

    }
}
