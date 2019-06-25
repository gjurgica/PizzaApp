using PizzaAppDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaAppDataAccess
{
    public class OrderRepository : IRepository<Order>
    {
        public void Create(Order entity)
        {
            int newId = StorageDb.OrderId++;
            entity.Id = newId;
            StorageDb.Orders.Add(entity);
        }

        public void Delete(int id)
        {
            Order order = StorageDb.Orders.FirstOrDefault(x => x.Id == id);
            if(order != null)
            {
                StorageDb.Orders.Remove(order);
            }
        }

        public List<Order> GetAll()
        {
            return StorageDb.Orders;
        }

        public Order GetById(int id)
        {
            return StorageDb.Orders.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Order entity)
        {
            Order order = StorageDb.Orders.FirstOrDefault(x => x.Id == entity.Id);
            if(order != null)
            {
                int index = StorageDb.Orders.IndexOf(order);
                StorageDb.Orders[index] = order;
            }
        }
    }
}
