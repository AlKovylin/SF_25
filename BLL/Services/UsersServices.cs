using SF_25.BLL.Models;
using SF_25.DAL.Interfaces.Repository;
using SF_25.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace SF_25.BLL.Services
{
    public class UsersServices
    {
        IUserRepository userRepository;

        public UsersServices()
        {
            userRepository = new UserRepository();
        }

        public List<UserModel> GetAllUsers()
        {
            var query = userRepository.GetAllUsers();

            var AllUsers = new List<UserModel>();

            foreach(var user in query)
            {
                AllUsers.Add(new UserModel
                {
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Phone = user.Phone,
                    Email = user.Email
                });
            }

            return AllUsers;
        }
    }
}
