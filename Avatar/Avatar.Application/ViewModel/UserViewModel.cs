using Avatar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Application.ViewModel
{
    public class UserViewModel
    {
        public int id { get; set; }
        public int idCategory { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public IEnumerable<CompanyViewModel> companies { get; set; }
        public IEnumerable<CourseViewModel> courses { get; set; }

        public static UserViewModel ToViewModel(User user)
        {
            return new UserViewModel()
            {
                id = user.Id,
                name = user.Name,
                email = user.Email,
                companies = CompanyViewModel.ToViewModelList(user.Companies),
                courses = CourseViewModel.ToViewModelList(user.Courses)
            };
        }

        public static IEnumerable<UserViewModel> ToViewModelList(IEnumerable<User> users)
        {
            if (users == null)
                return new List<UserViewModel>();

            var usersViewModel = new List<UserViewModel>();

            foreach (var user in users)
            {
                usersViewModel.Add(ToViewModel(user));
            }

            return usersViewModel;
        }

        public User ToDomain()
        {
            return new User(id, name, email);
        }
    }
}
