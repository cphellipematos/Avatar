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
    public class DeleteCourseService : ServerCommand, IService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly DeleteCourseCommand _courseCommand;

        public DeleteCourseService(DeleteCourseCommand courseCommand, ICourseRepository courseRepository) 
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

            _courseRepository.Delete(_courseCommand.Id);
        }

        public void Validate()
        {
            AddNotification(Assert.IsNotNull(_courseRepository.GetById(_courseCommand.Id), "Id", "Sorry, this current Id is not in our system!"));
        }
    }
}
