using Avatar.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Avatar.Application.ViewModel;
using Avatar.Domain.Interfaces.Services;

namespace Avatar.Application.Service
{
    public class CompanyAppService : ICompanyAppService
    {
        private readonly ICompanyService _companyService;

        public CompanyAppService(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        public void CreateCompany(CompanyViewModel company)
        {
            _companyService.CreateCompany(company.ToDomain());
        }

        public void DeleteCompany(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CompanyViewModel> GetAllCompanies()
        {
            return CompanyViewModel.ToViewModelList(_companyService.GetAllCompanies());
        }

        public CompanyViewModel GetCompanyById(int id)
        {
            throw new NotImplementedException();
        }

        public CompanyViewModel UpdateCompany(CompanyViewModel company)
        {
            throw new NotImplementedException();
        }
    }
}
