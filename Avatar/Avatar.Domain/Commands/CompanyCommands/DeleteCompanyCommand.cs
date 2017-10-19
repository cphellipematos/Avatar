using DomainNotificationHelperCore.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Domain.Commands.CompanyCommands
{
    public class DeleteCompanyCommand : Command
    {
        public int Id { get; set; }

        public DeleteCompanyCommand(int id)
        {
            Id = id;

            Validate();
        }

        private void Validate()
        {
            // Add notifications if necessary
        }
    }
}
