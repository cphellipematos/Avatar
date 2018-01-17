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
        public string Title { get; set; }
        public string Linkedin { get; set; }
        public string Github { get; set; }
        public string Resume { get; set; }


        public GetUserByIdCommand(int id)
        {
            Id = id;

            Validate();
        }

        public GetUserByIdCommand ToCommand(User user)
        {
            Id = user.Id;
            Name = user.Name;
            Title = user.Title;
            Linkedin = user.Linkedin;
            Github = user.Github;
            Resume = user.Resume;

            return this;
        }

        public void Validate()
        {
            //AddNotification(Assert.AreEquals(Id.ToString(), "0", "Id", "Id cant be zero!!"));
        }
    }
}
