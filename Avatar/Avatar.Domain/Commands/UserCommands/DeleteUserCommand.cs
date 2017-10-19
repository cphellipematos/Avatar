using DomainNotificationHelperCore.Assertions;
using DomainNotificationHelperCore.Commands;

namespace Avatar.Domain.Commands.UserCommands
{
    public class DeleteUserCommand : Command
    {
        public int Id { get; set; }

        public DeleteUserCommand(int id)
        {
            Id = id;

            Validate();
        }

        public void Validate()
        {
            AddNotification(Assert.IsNotNull(Id, "Id", "You should provide an User id!!"));            
        }
    }
}
