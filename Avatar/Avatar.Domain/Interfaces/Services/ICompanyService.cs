using Avatar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Domain.Interfaces.Services
{
    public interface ICompanyService
    {
        void CreateCompany(Company company);
        void DeleteCompany(int id);
        Company GetCompanyById(int id);
        IEnumerable<Company> GetAllCompanies();
        Company UpdateCompany(Company company);
    }
}
