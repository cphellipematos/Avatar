using Avatar.Application.Interfaces;
using System;
using System.Collections.Generic;
using Avatar.Application.ViewModel;
using Avatar.Domain.Interfaces.Services;

namespace Avatar.Application.Service
{
    public class CourseAppService : ICourseAppService
    {
        private readonly ICourseService _courseService;

        public CourseAppService(ICourseService courseService)
        {
            _courseService = courseService;
        }
        public void CreateCompany(CourseViewModel course)
        {
            _courseService.CreateCourse(course.ToDomain());
        }

        public void DeleteCompany(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CourseViewModel> GetAllCourses()
        {
            return CourseViewModel.ToViewModelList(_courseService.GetAllCourses());
        }

        public CourseViewModel GetCourseById(int id)
        {
            throw new NotImplementedException();
        }

        public CourseViewModel UpdateCourse(CourseViewModel course)
        {
            throw new NotImplementedException();
        }
    }
}
