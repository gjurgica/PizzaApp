using PizzaAppDomain;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaAppServices
{
    public interface IOrderService
    {
        List<Order> GetAllOrders();
        Order GetOrderById(int id);
        void CreateOrder(Order order);
        void UpdateOrder(Order order);
        void DeleteOrder(int id);
    }
}
