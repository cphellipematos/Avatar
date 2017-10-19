using Avatar.Application.ViewModel;
using Avatar.Domain.Commands.CourseCommands;
using DomainNotificationHelperCore.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Application.Interfaces
{
    public interface ICourseAppService
    {
        Command CreateCourse(CourseViewModel course);
        Command DeleteCourse(int id);
        CourseViewModel GetCourseById(int id);
        IEnumerable<GetAllCourseCommand> GetAllCourses();
        Command UpdateCourse(CourseViewModel course);
    }
}
