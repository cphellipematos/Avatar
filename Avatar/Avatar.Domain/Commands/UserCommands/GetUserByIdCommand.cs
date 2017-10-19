using Avatar.Domain.Entities;
using DomainNotificationHelperCore.Assertions;
using DomainNotificationHelperCore.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Domain.Commands.UserCommands
{
    public class GetUserByIdCommand : Command
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public GetUserByIdCommand(int id)
        {
            Id = id;

            Validate();
        }

        public GetUserByIdCommand ToCommand(User user)
        {
            Id = user.Id;
            Name = user.Name;
            Email = user.Email;

            return this;
        }

        public void Validate()
        {
            //AddNotification(Assert.AreEquals(Id.ToString(), "0", "Id", "Id cant be zero!!"));
        }
    }
}
