using Avatar.Domain.Commands.UserCommands;
using Avatar.Domain.Interfaces.Repository;
using DomainNotificationHelperCore.Assertions;
using DomainNotificationHelperCore.Commands;

namespace Avatar.Domain.Services.UserServices
{
    public class DeleteUserService : ServerCommand
    {
        private readonly IUserRepository _userRepository;
        private DeleteUserCommand _userCommand;

        public DeleteUserService(DeleteUserCommand userCommand, IUserRepository userRepository) 
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

            _userRepository.Delete(_userCommand.Id);
        }

        public void Validate()
        {
            AddNotification(Assert.IsNotNull(_userRepository.GetById(_userCommand.Id), "Id", "Sorry, this current Id is not in our system!"));
        }
    }
}
