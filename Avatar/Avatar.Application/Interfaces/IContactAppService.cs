using Avatar.Application.ViewModel;
using DomainNotificationHelperCore.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Application.Interfaces
{
    public interface IContactAppService
    {
        Command CreateContact(ContactViewModel contact);
    }
}
