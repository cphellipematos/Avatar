using Avatar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Application.ViewModel
{
    public class CompanyViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public static CompanyViewModel ToViewModel(Company company)
        {
            return new CompanyViewModel() {
                Id = company.Id,
                Name = company.Name,
                StartDate = company.StartDate,
                EndDate = company.EndDate,
                Description = company.Description,
                InsertDate = company.InsertDate,
                UpdateDate = company.UpdateDate
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
    }
}
