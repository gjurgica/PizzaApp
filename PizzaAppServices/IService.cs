using PizzaAppDomain;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaAppServices
{
    public interface IService
    {
        List<Pizza> GetAllPizzas();
        Pizza GetPizzaById(int id);
        void CreatePizza(Pizza pizza);
        void UpdatePizza(Pizza pizza);
        void DeletePizza(int id);
    }
}
