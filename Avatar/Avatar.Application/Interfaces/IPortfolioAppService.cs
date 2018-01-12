using Avatar.Domain.Commands.PortfolioCommands;
using DomainNotificationHelperCore.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Application.Interfaces
{
    public interface IPortfolioAppService
    {
        IEnumerable<GetPortfoliosCommand> GetPortfolios();
    }
}
