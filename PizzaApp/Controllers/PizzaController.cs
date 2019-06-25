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
    public class PizzaController : Controller
    {
        private readonly IService _pizzaService;
        public PizzaController(IService pizzaService)
        {
            _pizzaService = pizzaService;
        }
        public IActionResult Index()
        {

            List<Pizza> pizzaList = _pizzaService.GetAllPizzas();

            MenuViewModel menu = new MenuViewModel("Enrico", pizzaList);
            return View(menu);
        }
    }
}