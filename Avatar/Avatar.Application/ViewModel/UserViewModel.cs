using Avatar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Application.ViewModel
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public int IdCategory { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string InsertDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool Status { get; set; }

        public static UserViewModel ToViewModel(User user)
        {
            return new UserViewModel()
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                Status = user.Status
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
    }
}
