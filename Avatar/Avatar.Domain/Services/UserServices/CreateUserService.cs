using Avatar.Domain.Commands.UserCommands;
using Avatar.Domain.Entities;
using Avatar.Domain.Interfaces.Repository;
using Avatar.Domain.Interfaces.Services;
using DomainNotificationHelperCore.Assertions;
using DomainNotificationHelperCore.Commands;

namespace Avatar.Domain.Services.UserServices
{
    public class CreateUserService : ServerCommand, IService
    {
        private readonly CreateUserCommand _userCommand;
        private readonly IUserRepository _userRepository;

        public CreateUserService(CreateUserCommand userCommand, IUserRepository userRepository)
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

            _userRepository.Create(_userCommand.ToDomain());
        }

        public void Validate()
        {
            AddNotification(Assert.IsNull(_userRepository.GetUserByEmail(_userCommand.Email), "Email", "This e-mails is already registered!"));
        }
    }
}
