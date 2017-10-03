using Avatar.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Avatar.Domain.Entities;
using Avatar.Domain.Interfaces.Repository;

namespace Avatar.Domain.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;

        public CompanyService(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }
        public void CreateCompany(Company company)
        {
            _companyRepository.Create(company);
        }

        public void DeleteCompany(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Company> GetAllCompanies()
        {
            return _companyRepository.GetAll();
        }

        public Company GetCompanyById(int id)
        {
            throw new NotImplementedException();
        }

        public Company UpdateCompany(Company company)
        {
            throw new NotImplementedException();
        }
    }
}
