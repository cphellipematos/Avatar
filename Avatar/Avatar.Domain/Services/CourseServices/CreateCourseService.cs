using Avatar.Domain.Commands.CourseCommands;
using Avatar.Domain.Interfaces.Repository;
using Avatar.Domain.Interfaces.Services;
using DomainNotificationHelperCore.Commands;

namespace Avatar.Domain.Services.CourseServices
{
    public class CreateCourseService : ServerCommand, IService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly CreateCourseCommand _courseCommand;

        public CreateCourseService(CreateCourseCommand courseCommand, ICourseRepository courseRepository) 
            : base(courseCommand)
        {
            _courseCommand = courseCommand;
            _courseRepository = courseRepository;
            Run();
        }

        public void Run()
        {
            Validate();

            if (HasNotifications())
                return;

            _courseRepository.Create(_courseCommand.ToDomain());
        }

        public void Validate()
        {
            // Insert Validations if necessary
        }
    }
}
