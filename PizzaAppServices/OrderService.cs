using System;
using System.Collections.Generic;
using System.Text;
using PizzaAppDataAccess;
using PizzaAppDomain;

namespace PizzaAppServices
{
    public class OrderService : IOrderService
    {
        private readonly IRepository<Order> _orderRepository;
        public OrderService(IRepository<Order> orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public void CreateOrder(Order order)
        {
            _orderRepository.Create(order);
        }

        public void DeleteOrder(int id)
        {
            _orderRepository.Delete(id);
        }

        public List<Order> GetAllOrders()
        {
            return _orderRepository.GetAll();
        }

        public Order GetOrderById(int id)
        {
            return _orderRepository.GetById(id);
        }

        public void UpdateOrder(Order order)
        {
            _orderRepository.Update(order);
        }
    }
}
