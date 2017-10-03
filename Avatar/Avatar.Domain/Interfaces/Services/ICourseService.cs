using Avatar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Domain.Interfaces.Services
{
    public interface ICourseService
    {
        void CreateCourse(Course course);
        void DeleteCourse(int id);
        Course GetCourseById(int id);
        IEnumerable<Course> GetAllCourses();
        Course UpdateCompany(Course course);
    }
}
