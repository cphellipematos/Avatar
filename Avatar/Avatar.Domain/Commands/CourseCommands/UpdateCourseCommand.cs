using Avatar.Domain.Entities;
using DomainNotificationHelperCore.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Domain.Commands.CourseCommands
{
    public class UpdateCourseCommand : Command
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public string Description { get; set; }

        public int IdUser { get; set; }
        public int IdDurationType { get; set; }

        public UpdateCourseCommand(int id, string name, string company, string description, int idUser, int idDurationType)
        {
            Id = id;
            Name = name;
            Company = company;
            Description = description;
            IdUser = idUser;
            IdDurationType = idDurationType;

            Validate();
        }
        public Course ToDomain()
        {
            return new Course(Name, Company, Description, IdUser, IdDurationType);
        }

        private void Validate()
        {
            // Insert Notifications, if necessary.
        }
    }
}
