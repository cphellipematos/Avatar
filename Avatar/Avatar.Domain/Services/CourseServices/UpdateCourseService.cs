using Avatar.Domain.Commands.CourseCommands;
using Avatar.Domain.Interfaces.Repository;
using Avatar.Domain.Interfaces.Services;
using DomainNotificationHelperCore.Assertions;
using DomainNotificationHelperCore.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Domain.Services.CourseServices
{
    public class UpdateCourseService : ServerCommand, IService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly UpdateCourseCommand _courseCommand;

        public UpdateCourseService(UpdateCourseCommand courseCommand, ICourseRepository courseRepository) 
            : base(courseCommand)
        {
            _courseRepository = courseRepository;
            _courseCommand = courseCommand;
            Run();
        }

        public void Run()
        {
            Validate();

            if (HasNotifications())
                return;

            _courseRepository.Update(_courseCommand.ToDomain());
        }

        public void Validate()
        {
            AddNotification(Assert.IsNotNull(_courseRepository.GetById(_courseCommand.Id), "Id", "Sorry, this user is not in our system."));
        }
    }
}
