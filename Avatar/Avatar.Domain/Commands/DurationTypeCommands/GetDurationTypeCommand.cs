using Avatar.Domain.Entities;
using DomainNotificationHelperCore.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Domain.Commands.DurationTypeCommands
{
    public class GetDurationTypeCommand : Command
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }

        public GetDurationTypeCommand ToCommand(DurationType durationType)
        {
            return new GetDurationTypeCommand()
            {
                Id = durationType.Id,
                Name = durationType.Name,
                Status = durationType.Status
            };
        }
        public IEnumerable<GetDurationTypeCommand> ToCommandList(IEnumerable<DurationType> durationsType)
        {
            if (durationsType == null)
                return new List<GetDurationTypeCommand>();

            var commandList = new List<GetDurationTypeCommand>();

            foreach (var duration in durationsType)
            {
                commandList.Add(ToCommand(duration));
            }

            return commandList;
        }
    }
}
