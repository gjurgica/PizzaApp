using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PizzaAppDomain;
using PizzaAppServices;

namespace PizzaApp.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        public IActionResult Index()
        {
            List<User> users = _userService.GetAllUsers();
            return View(users);
        }
        public IActionResult Delete(int id)
        {
            List<User> users = _userService.GetAllUsers();
            _userService.DeleteUser(id);
            return View("Index", users);
        }
        public IActionResult Details(int id)
        {
            User user = _userService.GetUserById(id);
            return View(user);
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(User user)
        {
            List<User> users = _userService.GetAllUsers();
            if (!ModelState.IsValid)
            {
                return View();
            }
            _userService.CreateUser(user);
            return View("Index", users);
        }
        public IActionResult Edit(int id)
        {
            User user = _userService.GetUserById(id);
            return View(user);
        }
        [HttpPost]
        public IActionResult Edit(User user)
        {
            List<User> users = _userService.GetAllUsers();
            _userService.UpdateUser(user);
            return View("Index", users);
        }
    }
}