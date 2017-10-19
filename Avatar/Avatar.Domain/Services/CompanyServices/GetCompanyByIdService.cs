using Avatar.Domain.Commands.CompanyCommands;
using Avatar.Domain.Interfaces.Repository;
using Avatar.Domain.Interfaces.Services;
using DomainNotificationHelperCore.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Domain.Services.CompanyServices
{
    public class GetCompanyByIdService : ServerCommand, IService
    {
        private readonly GetCompanyByIdCommand _companyCommand;
        private readonly ICompanyRepository _companyRepository;

        public GetCompanyByIdService(GetCompanyByIdCommand companyCommand, ICompanyRepository companyRepository) 
            : base(companyCommand)
        {
            _companyCommand = companyCommand;
            _companyRepository = companyRepository;
            Run();
        }

        public void Run()
        {
            Validate();

            if (HasNotifications())
                return;

            _companyCommand.ToCommand(_companyRepository.GetById(_companyCommand.Id));
        }

        public void Validate()
        {
            // Add notifications if necessary
        }
    }
}
