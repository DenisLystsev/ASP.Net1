using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        public EmployeeView Person;

        private readonly List<EmployeeView> _employees = new List<EmployeeView>
        {
            new EmployeeView
            {
                Id = 1,
                FirstName = "Иван",
                Patronymic = "Иванович",
                LastName = "Иванов",
                Age = 22
            },
            new EmployeeView
            {
                Id = 2,
                FirstName = "Владислав",
                Patronymic = "Степанович",
                LastName = "Оченьстариков",
                Age = 125
            }
        };

        public IActionResult Index()
        {
            return View(_employees);
        }
    }
}