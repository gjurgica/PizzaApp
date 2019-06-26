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

            List<Pizza> pizzaList = _pizzaService.GetAllPizzas();;
            return View(pizzaList);
        }
        public IActionResult Details(int id)
        {
            List<Pizza> pizzaList = _pizzaService.GetAllPizzas();
            Pizza pizza = pizzaList.FirstOrDefault(x => x.Id == id);
            return View(pizza);
        }
        public IActionResult Edit(int id)
        {
            Pizza pizza = _pizzaService.GetPizzaById(id);
            return View(pizza);
        }
        [HttpPost]
        public IActionResult EditPizza(Pizza pizza)
        {
            List<Pizza> pizzaList = _pizzaService.GetAllPizzas();
            _pizzaService.UpdatePizza(pizza);
            return View("Index",pizzaList);
        }
        public IActionResult Delete(int id)
        {
            List<Pizza> pizzaList = _pizzaService.GetAllPizzas();
            _pizzaService.DeletePizza(id);
            return View("Index", pizzaList);
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Pizza pizza)
        {
            List<Pizza> pizzaList = _pizzaService.GetAllPizzas();
            if (!ModelState.IsValid)
            {
                return View();
            }
            _pizzaService.CreatePizza(pizza);
            return View("Index", pizzaList);
        }
    }
}