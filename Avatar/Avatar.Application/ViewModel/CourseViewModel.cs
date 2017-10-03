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

        public int id_user { get; set; }
        public int id_durationType { get; set; }

        public Course ToDomain()
        {
            return new Course(id, name, company, description, id_user, id_durationType);
        }

        public static CourseViewModel ToViewModel(Course course)
        {
            return new CourseViewModel() {
                id = course.Id,
                name = course.Name,
                company = course.Company,
                description = course.Description,
                id_user = course.UserId,
                id_durationType = course.DurationTypeID
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
