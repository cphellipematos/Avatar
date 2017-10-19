using Avatar.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Avatar.Application.ViewModel;
using Avatar.Domain.Interfaces.Services;
using Avatar.Domain.Interfaces.Repository;
using Avatar.Domain.Services.CompanyServices;
using DomainNotificationHelperCore.Commands;
using Avatar.Domain.Commands.CompanyCommands;

namespace Avatar.Application.Service
{
    public class CompanyAppService : ICompanyAppService
    {
        private readonly ICompanyRepository _companyRepository;

        public CompanyAppService(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        public Command CreateCompany(CompanyViewModel company)
        {
            var companyCommand = company.ToCreateCompanyCommand();
            new CreateCompanyService(companyCommand, _companyRepository);

            return companyCommand;
        }

        public Command DeleteCompany(int id)
        {
            var companyCommand = new DeleteCompanyCommand(id);
            new DeleteCompanyService(companyCommand, _companyRepository);

            return companyCommand;
        }

        public IEnumerable<GetAllCompaniesCommand> GetAllCompanies()
        {
            return new GetAllCompaniesCommand().ToCommandList(_companyRepository.GetAll());
        }

        public Command GetCompanyById(int id)
        {
            var companyCommand = new GetCompanyByIdCommand(id);
            new GetCompanyByIdService(companyCommand, _companyRepository);

            return companyCommand;
        }

        public Command UpdateCompany(CompanyViewModel company)
        {
            var companyCommand = company.ToUpdateCompanyCommand();
            new UpdateCompanyService(companyCommand, _companyRepository);

            return companyCommand;
        }
    }
}
