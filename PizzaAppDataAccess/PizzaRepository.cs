using PizzaAppDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaAppDataAccess
{
    public class PizzaRepository : IRepository<Pizza>
    {
        public void Create(Pizza entity)
        {
            int newId = StorageDb.PizzaId++;
            entity.Id = newId;
            StorageDb.Pizzas.Add(entity);
        }

        public void Delete(int id)
        {
            Pizza deleted = StorageDb.Pizzas.FirstOrDefault(x => x.Id == id);
            if(deleted != null)
            {
                StorageDb.Pizzas.Remove(deleted);
            }
        }

        public List<Pizza> GetAll()
        {
            return StorageDb.Pizzas;
        }

        public Pizza GetById(int id)
        {
            return StorageDb.Pizzas.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Pizza entity)
        {
            Pizza pizza = StorageDb.Pizzas.FirstOrDefault(x => x.Id == entity.Id);
            if(pizza != null)
            {
                int index = StorageDb.Pizzas.IndexOf(pizza);
                StorageDb.Pizzas[index] = pizza;
            }
        }
    }
}
