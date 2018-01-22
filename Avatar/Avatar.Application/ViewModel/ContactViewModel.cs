using Avatar.Domain.Commands.ContactCommands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Application.ViewModel
{
    public class ContactViewModel
    {
        public string company { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string description { get; set; }

        public CreateContactCommand ToCreateCommand()
        {
            return new CreateContactCommand(0, company, name, email, phone, description);
        }
    }
}
