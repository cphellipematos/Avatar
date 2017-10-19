using Avatar.Domain.Commands.CourseCommands;
using Avatar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Application.ViewModel
{
    public class CourseViewModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string company { get; set; }
        public string description { get; set; }

        public int idUser { get; set; }
        public int idDurationType { get; set; }

        public CreateCourseCommand ToCreateCommand()
        {
            return new CreateCourseCommand(name, company, description, idDurationType, idUser);
        }
        public UpdateCourseCommand ToUpdateCommand()
        {
            return new UpdateCourseCommand(id, name, company, description, idUser, idDurationType);
        }

    }
}
