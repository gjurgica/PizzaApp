using PizzaAppDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaAppDataAccess
{
    public class UserRepository : IRepository<User>
    {
        public void Create(User entity)
        {
            int newId = StorageDb.UserId++;
            entity.Id = newId;
            StorageDb.Users.Add(entity);
        }

        public void Delete(int id)
        {
            User deleted = StorageDb.Users.FirstOrDefault(x => x.Id == id);
            if(deleted != null)
            {
                StorageDb.Users.Remove(deleted);
            }
        }

        public List<User> GetAll()
        {
            return StorageDb.Users;
        }

        public User GetById(int id)
        {
            return StorageDb.Users.FirstOrDefault(x => x.Id == id);
        }

        public void Update(User entity)
        {
            User user = StorageDb.Users.FirstOrDefault(x => x.Id == entity.Id);
            if(user != null)
            {
                int index = StorageDb.Users.IndexOf(user);
                StorageDb.Users[index] = entity;
            }
        }
    }
}
