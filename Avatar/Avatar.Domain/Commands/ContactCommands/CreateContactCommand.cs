using Avatar.Domain.Entities;
using DomainNotificationHelperCore.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Domain.Commands.ContactCommands
{
    public class CreateContactCommand : Command
    {
        public int Id { get; set; }
        public string Company { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Description { get; set; }

        public CreateContactCommand(int id, string company, string name, string email, string phone, string description)
        {
            Id = id;
            Company = company;
            Name = name;
            Email = email;
            Phone = phone;
            Description = description;

            Validate();
        }

        public Contact ToDomain()
        {
            return new Contact(Id, Company, Name, Email, Phone, Description);
        }
        private void Validate()
        {
            // Insert Notification if necessary
        }
    }
}
