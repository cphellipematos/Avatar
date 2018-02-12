using Avatar.Domain.Entities;
using DomainNotificationHelperCore.Assertions;
using DomainNotificationHelperCore.Commands;


namespace Avatar.Domain.Commands.UserCommands
{
    public class CreateUserCommand : Command
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }

        public CreateUserCommand(string name, string email)
        {
            Name = name;
            Email = email;

            Validate();
        }

        public User ToDomain()
        {
            return new User(Name, Email);
        }

        protected void Validate()
        {
            AddNotification(Assert.NotEmpty(Name, "Empty User Name", "Please, provide a Username"));            
            AddNotification(Assert.NotEmpty(Email, "Empty Email", "Please, provide a E-mail!"));
        }

    }
}
