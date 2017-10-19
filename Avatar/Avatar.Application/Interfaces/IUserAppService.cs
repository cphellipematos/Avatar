using Avatar.Application.ViewModel;
using Avatar.Domain.Commands;
using Avatar.Domain.Commands.UserCommands;
using DomainNotificationHelperCore.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Application.Interfaces
{
    public interface IUserAppService
    {
        Command CreateUser(UserViewModel user);
        Command DeleteUser(int id);
        Command GetUserById(int id);
        IEnumerable<GetAllUserCommand> GetAllUsers();
        Command UpdateUser(UserViewModel user);

    }
}
