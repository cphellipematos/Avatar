
using System.Collections.Generic;
using Avatar.Application.Interfaces;
using Avatar.Application.ViewModel;
using Avatar.Domain.Interfaces.Services;
using Avatar.Domain.Services.UserServices;
using Avatar.Domain.Interfaces.Repository;
using Avatar.Domain.Commands;
using DomainNotificationHelperCore.Commands;
using Avatar.Domain.Commands.UserCommands;
using Avatar.Domain.Entities;

namespace Avatar.Application.Service
{
    public class UserAppService : IUserAppService
    {
        #region Properties        
        private readonly IUserRepository _userRepository;
        #endregion
        
        #region Constructor        
        public UserAppService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        #endregion

        #region Methods        
        public Command CreateUser(UserViewModel userViewModel)
        {
            var userCommand = userViewModel.ToCreateCommand();
            new CreateUserService(userCommand, _userRepository);
            
            return userCommand;
        }

        public Command DeleteUser(int id)
        {
            var userCommand = new DeleteUserCommand(id);
            new DeleteUserService(userCommand, _userRepository);

            return userCommand;
        }

        public IEnumerable<GetAllUserCommand> GetAllUsers()
        {
            return GetAllUserCommand.ToCommandList(_userRepository.GetAll());
        }

        public Command GetUserById(int id)
        {
            var userCommand = new GetUserByIdCommand(id);
            new GetUserByIdService(userCommand, _userRepository);

            return userCommand;
        }

        public Command UpdateUser(UserViewModel user)
        {
            var userCommand = user.ToUpdateCommand();

            new UpdateUserService(userCommand, _userRepository);

            return userCommand;
        }
        #endregion 
    }
}
