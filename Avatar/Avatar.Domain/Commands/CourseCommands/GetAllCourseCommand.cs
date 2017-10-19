using Avatar.Domain.Entities;
using DomainNotificationHelperCore.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Domain.Commands.CourseCommands
{
    public class GetAllCourseCommand : Command
    {
        public int id { get; private set ; }
        public string name { get; private set; }
        public string company { get; private set; }
        public string description { get; private set; }
        public int durationTypeID { get; private set; }
        public int userId { get; private set; }

        public static GetAllCourseCommand ToCommand(Course course)
        {
            return new GetAllCourseCommand()
            {
                id = course.Id,
                name = course.Name,
                company = course.Company,
                description = course.Description,
                durationTypeID = course.DurationTypeID,
                userId = course.UserId
            };
        }

        public static List<GetAllCourseCommand> ToCommandList(IEnumerable<Course> courses)
        {
            if (courses == null)
                return new List<GetAllCourseCommand>(); ;

            var usersCommand = new List<GetAllCourseCommand>();

            foreach (var course in courses)
            {
                usersCommand.Add(ToCommand(course));
            }

            return usersCommand;
        }
    }
}
