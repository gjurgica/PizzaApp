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
            OrderViewModel order = new OrderViewModel
            {
                RestorantName = "Enrico",
                Pizzas = new List<Pizza>
                {
                    new Pizza(1, "Capri", "The best capri pizza in town!", 160),
                    new Pizza(2, "Pepperoni", "The best pepperoni pizza in town!", 180),
                }
            };
            return View(order);
        }
    }
}