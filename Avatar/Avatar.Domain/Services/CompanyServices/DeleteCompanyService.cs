using Avatar.Domain.Commands.CompanyCommands;
using Avatar.Domain.Interfaces.Repository;
using Avatar.Domain.Interfaces.Services;
using DomainNotificationHelperCore.Assertions;
using DomainNotificationHelperCore.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Domain.Services.CompanyServices
{
    public class DeleteCompanyService : ServerCommand, IService
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly DeleteCompanyCommand _companyCommand;
        public DeleteCompanyService(DeleteCompanyCommand companyCommand, ICompanyRepository companyRepository) 
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

            _companyRepository.Delete(_companyCommand.Id);
        }

        public void Validate()
        {
            AddNotification(Assert.IsNotNull(_companyRepository.GetById(_companyCommand.Id), "Id", "Sorry, this company is not in our system!"));
        }
    }
}
