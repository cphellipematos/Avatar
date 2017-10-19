using Avatar.Domain.Commands.UserCommands;
using Avatar.Domain.Entities;
using Avatar.Domain.Interfaces.Repository;
using DomainNotificationHelperCore.Assertions;
using DomainNotificationHelperCore.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Domain.Services.UserServices
{
    public class GetUserByIdService : ServerCommand
    {
        private IUserRepository _userRepository;
        private GetUserByIdCommand _userCommand;        

        public GetUserByIdService(GetUserByIdCommand userCommand, IUserRepository userRepository)
            : base(userCommand)
        {
            _userCommand = userCommand;
            _userRepository = userRepository;
            Run();
        }

        public void Run()
        {
            Validate();

            if (HasNotifications())
                return;

            _userCommand.ToCommand(_userRepository.GetById(_userCommand.Id));
        }

        public void Validate()
        {   
            AddNotification(Assert.IsNotNull(_userRepository.GetById(_userCommand.Id), "Id", "This user id doesn't exist!!"));
        }
    }
}
