using PizzaAppDomain;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaAppServices
{
    public interface IUserService
    {
        List<User> GetAllUsers();
        User GetUserById(int id);
        void CreateUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int id);
    }
}
