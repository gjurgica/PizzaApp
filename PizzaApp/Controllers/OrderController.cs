using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PizzaAppDomain;
using PizzaAppServices;

namespace PizzaApp.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        public IActionResult Index()
        {
            List<Order> orders = _orderService.GetAllOrders();
            return View(orders);
        }
        public IActionResult Details(int id)
        {
            Order order = _orderService.GetOrderById(id);
            return View(order);
        }
        public IActionResult Delete(int id)
        {
            List<Order> orders = _orderService.GetAllOrders();
            _orderService.DeleteOrder(id);
            return View("Index",orders);
        }
        public IActionResult Edit(int id)
        {
            Order order = _orderService.GetOrderById(id);
            return View(order);
        }
        public IActionResult EditOrder(Order order)
        {
            List<Order> orders = _orderService.GetAllOrders();
            _orderService.UpdateOrder(order);
            return View("Index", orders);
        }
        
    }
}