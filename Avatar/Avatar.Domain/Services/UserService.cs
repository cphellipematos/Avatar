using Avatar.Domain.Entities;
using Avatar.Domain.Interfaces.Repository;
using Avatar.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Domain.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public void CreateUser(User user)
        {
            _userRepository.Create(user);
        }

        public void DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _userRepository.GetAll();
        }

        public void GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser()
        {
            throw new NotImplementedException();
        }
    }
}
