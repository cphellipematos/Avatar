using Avatar.Domain.Commands.UserCommands;
using Avatar.Domain.Interfaces.Repository;
using DomainNotificationHelperCore.Assertions;
using DomainNotificationHelperCore.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Domain.Services.UserServices
{
    public class UpdateUserService : ServerCommand
    {
        private IUserRepository _userRepository;
        private UpdateUserCommand _userCommand;

        public UpdateUserService(UpdateUserCommand userCommand, IUserRepository userRepository) 
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
                                                                                
            _userRepository.Update(_userCommand.ToDomain());            
        }

        public void Validate()
        {
            AddNotification(Assert.IsNotNull(_userRepository.GetById(_userCommand.Id), "Id", "Sorry, this current id is not in our system."));            
        }


    }
}
