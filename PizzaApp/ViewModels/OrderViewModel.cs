using PizzaAppDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApp.ViewModels
{
    public class OrderViewModel
    {
        public string RestorantName { get; set; }
        public List<Pizza> Pizzas { get; set; }
        public double TotalPrice
        {
            get
            {
                return Pizzas.Sum(x => x.GetPrice(x.Size)) + 10;
            }

        }
    }
}
