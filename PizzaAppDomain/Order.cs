﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaAppDomain
{
    public class Order
    {
        public int Id { get; set; }
        public User User { get; set; }
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
