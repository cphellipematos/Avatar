using Avatar.Domain.Commands.UserCommands;
using Avatar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Application.ViewModel
{
    public class UserViewModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string title { get; set; }
        public string linkedin { get; set; }
        public string github { get; set; }
        public string twitter { get; set; }
        public string resume { get; set; }

        public IEnumerable<CompanyViewModel> companies { get; set; }
        public IEnumerable<CourseViewModel> courses { get; set; }

        public CreateUserCommand ToCreateCommand()
        {
            return new CreateUserCommand(name, email);
        }

        public UpdateUserCommand ToUpdateCommand()
        {
            return new UpdateUserCommand(id, name, email);
        }
    }
}
    