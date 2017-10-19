using Avatar.Domain.Commands.CompanyCommands;
using Avatar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Application.ViewModel
{
    public class CompanyViewModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string role { get; set; }
        public string description { get; set; }
        public int idUser { get; set; }
        public int idDurationType { get; set; }

        public CreateCompanyCommand ToCreateCommand()
        {
            return new CreateCompanyCommand(id, name, role, description, idUser, idDurationType);
        }

        public UpdateCompanyCommand ToUpdateCommand()
        {
            return new UpdateCompanyCommand(id, name, role, description, idUser, idDurationType);
        }

    }
}
