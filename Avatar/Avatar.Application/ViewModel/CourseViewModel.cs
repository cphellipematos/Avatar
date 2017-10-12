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

        public Course ToDomain()
        {
            return new Course(id, name, company, description, idUser, idDurationType);
        }

        public static CourseViewModel ToViewModel(Course course)
        {
            return new CourseViewModel() {
                id = course.Id,
                name = course.Name,
                company = course.Company,
                description = course.Description,
                idUser = course.UserId,
                idDurationType = course.DurationTypeID
            };
        }

        public static IEnumerable<CourseViewModel> ToViewModelList(IEnumerable<Course> courses)
        {
            if (courses == null)
                return new List<CourseViewModel>();

            var coursesViewModel = new List<CourseViewModel>();

            foreach (var course in courses)
            {
                coursesViewModel.Add(ToViewModel(course));
            }

            return coursesViewModel;
        }

    }
}
