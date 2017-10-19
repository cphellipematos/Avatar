using Avatar.Domain.Commands.CompanyCommands;
using Avatar.Domain.Interfaces.Repository;
using Avatar.Domain.Interfaces.Services;
using DomainNotificationHelperCore.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Domain.Services.CompanyServices
{
    public class UpdateCompanyService : ServerCommand, IService
    {
        private readonly UpdateCompanyCommand _companyCommand;
        private readonly ICompanyRepository _companyRepository;
        public UpdateCompanyService(UpdateCompanyCommand companyCommand, ICompanyRepository companyRepository) 
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

            _companyRepository.Update(_companyCommand.ToDomain());
        }

        public void Validate()
        {
            // Add notification if necessary
        }
    }
}
