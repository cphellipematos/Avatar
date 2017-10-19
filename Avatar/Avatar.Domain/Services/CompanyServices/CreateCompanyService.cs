using Avatar.Domain.Commands.CompanyCommands;
using Avatar.Domain.Interfaces.Repository;
using Avatar.Domain.Interfaces.Services;
using DomainNotificationHelperCore.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Domain.Services.CompanyServices
{
    public class CreateCompanyService : ServerCommand, IService
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly CreateCompanyCommand _companyCommand;
        public CreateCompanyService(CreateCompanyCommand companyCommand, ICompanyRepository companyRepository) 
            : base(companyCommand)
        {
            _companyRepository = companyRepository;
            _companyCommand = companyCommand;
            Run();
        }

        public void Run()
        {
            Validate();

            if (HasNotifications())
                return;

            _companyRepository.Create(_companyCommand.ToDomain());
        }

        public void Validate()
        {
            // Insert notifications if necessary
        }
    }
}
