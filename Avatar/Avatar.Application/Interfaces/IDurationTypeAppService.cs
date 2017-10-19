using Avatar.Application.ViewModel;
using Avatar.Domain.Commands.DurationTypeCommands;
using DomainNotificationHelperCore.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Application.Interfaces
{
    public interface IDurationTypeAppService
    {
        IEnumerable<GetDurationTypeCommand> GetAllDurationType();
    }
}
