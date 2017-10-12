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

        public static CompanyViewModel ToViewModel(Company company)
        {
            return new CompanyViewModel() {
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
            return new Company(id, name, description, role, idUser, idDurationType);
        }
    }
}
