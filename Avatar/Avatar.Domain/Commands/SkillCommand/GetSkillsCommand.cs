using DomainNotificationHelperCore.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using Avatar.Domain.Entities;

namespace Avatar.Domain.Commands.SkillCommand
{
    public class GetSkillsCommand : Command
    {
        public int id { get; private set; }
        public string title { get; private set; }
        public int progress { get; private set; }
        public string img { get; private set; }
        public int idUser { get; private set; }

        public GetSkillsCommand ToCommand(Skill skill)
        {
            return new GetSkillsCommand()
            {
                id = skill.Id,
                title = skill.Title,
                progress = skill.Progress,
                img = skill.Img
            };
        }

        public IEnumerable<GetSkillsCommand> ToCommandList(IEnumerable<Skill> skills)
        {
            if (skills == null)
                return new List<GetSkillsCommand>();

            var skillsCommand = new List<GetSkillsCommand>();

            foreach (var skill in skills)
            {
                skillsCommand.Add(ToCommand(skill));
            }
            return skillsCommand;
        }
    }
}
