using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaAppDataAccess
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        T GetById(int id);
        void Create(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
