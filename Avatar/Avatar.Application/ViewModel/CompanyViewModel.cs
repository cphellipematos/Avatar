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


        public CreateCompanyCommand ToCreateCompanyCommand()
        {
            return new CreateCompanyCommand(id, name, role, description, idUser, idDurationType);
        }

        public UpdateCompanyCommand ToUpdateCompanyCommand()
        {
            return new UpdateCompanyCommand(id, name, role, description, idUser, idDurationType);
        }

        public static CompanyViewModel ToViewModel(Company company)
        {
            return new CompanyViewModel()
            {
                id = company.Id,
                name = company.Name,
                description = company.Description,
                role = company.Role
            };
        }

        public static IEnumerable<CompanyViewModel> ToViewModelList(IEnumerable<Company> companies)
        {
            var companiesViewModel = new List<CompanyViewModel>();

            foreach (var company in companies)
            {
                companiesViewModel.Add(ToViewModel(company));
            }

            return companiesViewModel;
        }

        public Company ToDomain()
        {
            return new Company(name, description, role, idUser, idDurationType);
        }
    }
}
