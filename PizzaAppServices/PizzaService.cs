using System;
using System.Collections.Generic;
using System.Text;
using PizzaAppDataAccess;
using PizzaAppDomain;

namespace PizzaAppServices
{
    public class PizzaService : IService
    {
        private readonly IRepository<Pizza> _pizzaRepository;
        public PizzaService(IRepository<Pizza> pizzaRepository)
        {
            _pizzaRepository = pizzaRepository;
        }
        public void CreatePizza(Pizza pizza)
        {
            _pizzaRepository.Create(pizza);
        }

        public void DeletePizza(int id)
        {
            _pizzaRepository.Delete(id);
        }

        public List<Pizza> GetAllPizzas()
        {
            return _pizzaRepository.GetAll();
        }

        public Pizza GetPizzaById(int id)
        {
            return _pizzaRepository.GetById(id);
        }

        public void UpdatePizza(Pizza pizza)
        {
            _pizzaRepository.Update(pizza);
        }
    }
}
