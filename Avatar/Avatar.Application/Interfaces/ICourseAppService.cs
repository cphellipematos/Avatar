using Avatar.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Application.Interfaces
{
    public interface ICourseAppService
    {
        void CreateCompany(CourseViewModel course);
        void DeleteCompany(int id);
        CourseViewModel GetCourseById(int id);
        IEnumerable<CourseViewModel> GetAllCourses();
        CourseViewModel UpdateCourse(CourseViewModel course);
    }
}
