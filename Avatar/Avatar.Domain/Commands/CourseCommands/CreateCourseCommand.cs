using Avatar.Domain.Entities;
using DomainNotificationHelperCore.Assertions;
using DomainNotificationHelperCore.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Domain.Commands.CourseCommands
{
    public class CreateCourseCommand : Command
    {        
        public string Name { get; private set; }
        public string Company { get; private set; }
        public string Description { get; private set; }
        public int DurationTypeID { get; private set; }
        public int UserId { get; private set; }

        public CreateCourseCommand(string name, string company, string description, int durationTypeId, int userId)
        {            
            Name = name;
            Company = company;
            Description = description;
            DurationTypeID = durationTypeId;
            UserId = userId;

            Validate();
        }

        public Course ToDomain()
        {
            return new Course(Name, Company, Description, DurationTypeID, UserId);
        }

        private void Validate()
        {
            AddNotification(Assert.IsNotNull(Name, "Name", "Please, provide a course's name"));
            AddNotification(Assert.IsNotNull(Company, "Company", "Please, provide a company's name"));            
        }
    }
}
