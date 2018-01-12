using Avatar.Domain.Commands.SkillCommand;
using DomainNotificationHelperCore.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Application.Interfaces
{
    public interface ISkillAppService
    {
        IEnumerable<GetSkillsCommand> GetSkills();
    }
}
