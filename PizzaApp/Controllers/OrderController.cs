using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PizzaApp.ViewModels;
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
    }
}