using Avatar.Domain.Entities;
using DomainNotificationHelperCore.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Domain.Commands.CompanyCommands
{
    public class CreateCompanyCommand : Command
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string Description { get; set; }
        public int IdUser { get; set; }
        public int IdDurationType { get; set; }

        public CreateCompanyCommand(int id, string name, string role, string description, int idUser, int idDurationType)
        {
            Id = id;
            Name = name;
            Role = role;
            Description = description;
            IdUser = idUser;
            IdDurationType = idDurationType;

            Validate();
        }

        public Company ToDomain()
        {
            return new Company(Name, Description, Role, IdUser, IdDurationType);
        }

        private void Validate()
        {
            // Insert Notification if necessary
        }
    }
}
