using Avatar.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Avatar.Domain.Entities;
using Avatar.Domain.Interfaces.Repository;

namespace Avatar.Domain.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }
        public void CreateCourse(Course course)
        {
            _courseRepository.Create(course);
        }

        public void DeleteCourse(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Course> GetAllCourses()
        {
            return _courseRepository.GetAll();
        }

        public Course GetCourseById(int id)
        {
            throw new NotImplementedException();
        }

        public Course UpdateCompany(Course course)
        {
            throw new NotImplementedException();
        }
    }
}
