using Avatar.Application.Interfaces;
using Avatar.Domain.Commands.SkillCommand;
using Avatar.Domain.Interfaces.Repository;
using DomainNotificationHelperCore.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Application.Service
{
    public class SkillAppService : ISkillAppService
    {
        private ISkillRepository _skillRepository;

        public SkillAppService(ISkillRepository skillRepository)
        {
            _skillRepository = skillRepository;
        }

        public IEnumerable<GetSkillsCommand> GetSkills()
        {
            return new GetSkillsCommand().ToCommandList(_skillRepository.GetAll());
        }
    }
}
