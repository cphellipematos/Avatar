using Avatar.Application.ViewModel;
using Avatar.Domain.Commands.CompanyCommands;
using DomainNotificationHelperCore.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Application.Interfaces
{
    public interface ICompanyAppService
    {
        Command CreateCompany(CompanyViewModel company);
        Command DeleteCompany(int id);
        Command GetCompanyById(int id);
        IEnumerable<GetAllCompaniesCommand> GetAllCompanies();
        Command UpdateCompany(CompanyViewModel company);
    }
}
