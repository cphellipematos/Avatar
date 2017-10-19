using Avatar.Domain.Entities;
using DomainNotificationHelperCore.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Domain.Commands.CompanyCommands
{
    public class GetAllCompaniesCommand : Command
    {
        public int id { get; set; }
        public string name { get; set; }
        public string role { get; set; }
        public string description { get; set; }
        public int idUser { get; set; }
        public int idDurationType { get; set; }

        public GetAllCompaniesCommand ToCommand(Company company)
        {
            return new GetAllCompaniesCommand() {
                id = company.Id,
                name = company.Name,
                role = company.Role,
                description = company.Description,
                idUser = company.UserId,
                idDurationType = company.DurationTypeId
            };
        }

        public IEnumerable<GetAllCompaniesCommand> ToCommandList(IEnumerable<Company> companies)
        {
            if(companies == null)
                return new List<GetAllCompaniesCommand>();

            var companiesCommand = new List<GetAllCompaniesCommand>();

            foreach (var company in companies)
            {
                companiesCommand.Add(ToCommand(company));
            }
            return companiesCommand;
        }
    }
}
