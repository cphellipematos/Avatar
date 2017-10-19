using Avatar.Application.Interfaces;
using System;
using System.Collections.Generic;
using Avatar.Application.ViewModel;
using Avatar.Domain.Interfaces.Services;
using DomainNotificationHelperCore.Commands;
using Avatar.Domain.Services.CourseServices;
using Avatar.Domain.Interfaces.Repository;
using Avatar.Domain.Commands.CourseCommands;

namespace Avatar.Application.Service
{
    public class CourseAppService : ICourseAppService
    {
        private readonly ICourseRepository _courseRepository;

        public CourseAppService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public Command CreateCourse(CourseViewModel course)
        {
            var courseCommand = course.ToCreateCommand();
            new CreateCourseService(courseCommand, _courseRepository);

            return courseCommand;

        }

        public Command DeleteCourse(int id)
        {
            var courseCommand = new DeleteCourseCommand(id);
            new DeleteCourseService(courseCommand, _courseRepository);

            return courseCommand;
        }

        public IEnumerable<GetAllCourseCommand> GetAllCourses()
        {
            return GetAllCourseCommand.ToCommandList(_courseRepository.GetAll());
        }

        public CourseViewModel GetCourseById(int id)
        {
            throw new NotImplementedException();
        }

        public Command UpdateCourse(CourseViewModel course)
        {
            var courseCommand = course.ToUpdateCommand();
            new UpdateCourseService(courseCommand, _courseRepository);

            return courseCommand;
        }
    }
}
