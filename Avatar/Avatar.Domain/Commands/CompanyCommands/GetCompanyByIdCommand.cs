using Avatar.Domain.Entities;
using DomainNotificationHelperCore.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Domain.Commands.CompanyCommands
{
    public class GetCompanyByIdCommand : Command
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Role { get; private set; }
        public string Description { get; private set; }
        public int IdUser { get; private set; }
        public int IdDurationType { get; private set; }

        public GetCompanyByIdCommand(int id)
        {
            Id = id;

            Validate();
        }

        public GetCompanyByIdCommand ToCommand(Company company)
        {
            Id = company.Id;
            Name = company.Name;
            Role = company.Role;
            Description = company.Description;
            IdUser = company.UserId;
            IdDurationType = company.DurationTypeId;

            return this;
        }

        private void Validate()
        {
            // Add notification, if necessary
        }
    }
}
