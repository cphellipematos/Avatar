using Avatar.Domain.Entities;
using DomainNotificationHelperCore.Assertions;
using DomainNotificationHelperCore.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Domain.Commands.UserCommands
{
    public class UpdateUserCommand : Command
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public UpdateUserCommand(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;

            Validate();
        }

        public UpdateUserCommand ToCommand(User user)
        {
            Id = user.Id;
            Name = user.Name;

            return this;
        }

        public User ToDomain()
        {
            return new User(Name,Email);           
        }

        private void Validate()
        {
            AddNotification(Assert.IsGreaterThan(Id, 0, "Id", "Please, provide Id"));
        }
    }
}
