using Avatar.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Application.Interfaces
{
    public interface ICompanyAppService
    {
        void CreateCompany(CompanyViewModel company);
        void DeleteCompany(int id);
        CompanyViewModel GetCompanyById(int id);
        IEnumerable<CompanyViewModel> GetAllCompanies();
        CompanyViewModel UpdateCompany(CompanyViewModel company);
    }
}
