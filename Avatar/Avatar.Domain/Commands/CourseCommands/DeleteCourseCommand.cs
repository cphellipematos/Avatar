using DomainNotificationHelperCore.Assertions;
using DomainNotificationHelperCore.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Domain.Commands.CourseCommands
{
    public class DeleteCourseCommand : Command
    {
        public int Id { get; set; }

        public DeleteCourseCommand(int id)
        {
            Id = id;

            Validate();
        }

        public void Validate()
        {
            AddNotification(Assert.IsNotNull(Id, "Id", "You should provide an User id!!"));
        }
    }
}
