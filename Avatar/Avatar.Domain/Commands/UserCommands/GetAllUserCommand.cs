using Avatar.Domain.Entities;
using DomainNotificationHelperCore.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Domain.Commands.UserCommands
{
    public class GetAllUserCommand : Command
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }

        public static GetAllUserCommand ToCommand(User user)
        {
            return new GetAllUserCommand()
            {
                id = user.Id,
                name = user.Name,
                email = user.Email
            };
        }

        public static List<GetAllUserCommand> ToCommandList(IEnumerable<User> users)
        {
            if(users == null)
                return new List<GetAllUserCommand>(); ;

            var usersCommand = new List<GetAllUserCommand>();

            foreach (var user in users)
            {
                usersCommand.Add(ToCommand(user));
            }

            return usersCommand;
        }
    }
}
