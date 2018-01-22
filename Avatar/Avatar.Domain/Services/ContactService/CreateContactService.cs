using Avatar.Domain.Commands.ContactCommands;
using Avatar.Domain.Interfaces.Repository;
using Avatar.Domain.Interfaces.Services;
using DomainNotificationHelperCore.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Domain.Services.ContactService
{
    public class CreateContactService : ServerCommand, IService
    {
        private IContactRepository _contactRepository;
        private CreateContactCommand _contactCommand;

        public CreateContactService(CreateContactCommand contactCommand, IContactRepository contactRepository) 
            : base(contactCommand)
        {
            _contactRepository = contactRepository;
            _contactCommand = contactCommand;
            Run();
        }

        public void Run()
        {
            Validate();

            if (HasNotifications())
                return;

            _contactRepository.Create(_contactCommand.ToDomain());
        }

        public void Validate()
        {
            // Insert Validations if necessary
        }
    }
}
