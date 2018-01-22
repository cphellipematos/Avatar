using Avatar.Application.Interfaces;
using Avatar.Application.ViewModel;
using Avatar.Domain.Interfaces.Repository;
using Avatar.Domain.Services.ContactService;
using DomainNotificationHelperCore.Commands;

namespace Avatar.Application.Service
{
    public class ContactAppService : IContactAppService
    {
        private IContactRepository _contactRepository;

        public ContactAppService(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public Command CreateContact(ContactViewModel contact)
        {
            var contactCommand = contact.ToCreateCommand();
            new CreateContactService(contactCommand, _contactRepository);

            return contactCommand;
        }
    }
}
