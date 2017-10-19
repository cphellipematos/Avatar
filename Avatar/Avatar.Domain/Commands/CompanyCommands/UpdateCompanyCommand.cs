using Avatar.Domain.Entities;
using DomainNotificationHelperCore.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Domain.Commands.CompanyCommands
{
    public class UpdateCompanyCommand : Command
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Role { get; private set; }
        public string Description { get; private set; }
        public int IdUser { get; private set; }
        public int IdDurationType { get; private set; }

        public UpdateCompanyCommand(int id, string name, string role, string description, int idUser, int idDurationType)
        {
            Id = id;
            Name = name;
            Role = role;
            Description = description;
            IdUser = idUser;
            IdDurationType = idDurationType;
        }

        public Company ToDomain()
        {
            return new Company(Name, Description, Role, IdUser, IdDurationType);
        }
    }
}
