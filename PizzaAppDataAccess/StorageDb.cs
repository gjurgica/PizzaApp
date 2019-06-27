using PizzaAppDomain;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaAppDataAccess
{
    public static class StorageDb
    {
        public static int PizzaId = 3;
        public static int OrderId = 2;
        public static int UserId = 2;

        public static List<Pizza> Pizzas = new List<Pizza>
        {
            new Pizza(1, PizzaName.Capri, "The best capri pizza in town!", 160),
            new Pizza(2, PizzaName.Pepperoni, "The best pepperoni pizza in town!", 180),
            new Pizza(3, PizzaName.Napolitana, "The best napolitana pizza in town!", 140)
    };
        public static List<User> Users = new List<User>
        {
            new User
            {
                Id = 1,
                FirstName = "Viktorija",
                LastName = "Matevska",
                Address = "Vodnjanska br:4",
                Email = "viktorija12@gmail.com",
                Phone = "070/323-333",
                Password = "viki34"
            },
            new User
            {
                Id = 2,
                FirstName = "Aleksandar",
                LastName = "Veljanovski",
                Address = "Partizanska br:12",
                Email = "alek88@gmail.com",
                Phone = "070/211-999",
                Password = "alek789"
            }
        };
        public static List<Order> Orders = new List<Order>
        {
            new Order
            {
                Id = 1,
                User = new User
                {
                     Id = 2,
                     FirstName = "Aleksandar",
                     LastName = "Veljanovski",
                     Address = "Partizanska br:12",
                     Email = "alek88@gmail.com",
                     Phone = "070/211-999",
                     Password = "alek789"
                },
                Pizzas = new List<Pizza>
                {
                    new Pizza(1, PizzaName.Capri, "The best capri pizza in town!", 160),
                    new Pizza(2, PizzaName.Pepperoni, "The best pepperoni pizza in town!", 180),
                }
            },
             new Order
            {
                Id = 2,
                User = new User
                {
                    Id = 1,
                    FirstName = "Viktorija",
                    LastName = "Matevska",
                    Address = "Vodnjanska br:4",
                    Email = "viktorija12@gmail.com",
                    Phone = "070/323-333",
                    Password = "viki34"
                },
                Pizzas = new List<Pizza>
                {
                    new Pizza(2, PizzaName.Pepperoni, "The best pepperoni pizza in town!", 180),
                    new Pizza(3, PizzaName.Napolitana, "The best napolitana pizza in town!", 140)
                }
            },
        };
    }
}
