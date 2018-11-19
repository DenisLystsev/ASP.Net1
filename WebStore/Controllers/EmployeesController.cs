using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore.Models;
using WebStore.Infrastructure.Interfaces;

namespace WebStore.Controllers
{
    [Route("users")]
    public class EmployeesController : Controller
    {
        private readonly IEmployeesData _employeesData;

        public EmployeesController(IEmployeesData employeesData)
        {
            _employeesData = employeesData;
        }

        public IActionResult Index()
        {
            return View(_employeesData.GetAll());
        }

        [Route("id")]
        public IActionResult Details(int id)
        {
            var employee = _employeesData.GetById(id);

            if (ReferenceEquals(employee, null))
                return NotFound();

            return View(employee);
        }

        //Добавление или редактирование сотрудника
        [Route("edit/{id?}")]
        public IActionResult Edit(int? id)
        {
            EmployeeView model;
            if (id.HasValue)
            {
                model = _employeesData.GetById(id.Value);
                if (ReferenceEquals(model, null))
                    return NotFound();
            }
            else
            {
                model = new EmployeeView();
            }

            return View(model);
        }

        [HttpPost]
        [Route("edit/{id?}")]
        public IActionResult Edit(EmployeeView model)
        {
            if (model.Age < 18 && model.Age > 75)
            {
                ModelState.AddModelError("Age", "Ошибка возраста");
            }

            //Проверяем модель на валидность
            if (ModelState.IsValid)
            {
                if (model.Id > 0)
                {
                    var dbItem = _employeesData.GetById(model.Id);

                    if (ReferenceEquals(dbItem, null))
                        return NotFound();

                    dbItem.FirstName = model.FirstName;
                    dbItem.Patronymic = model.Patronymic;
                    dbItem.LastName = model.LastName;
                    dbItem.Age = model.Age;
                    dbItem.Position = model.Position;
                }
                else
                {
                    _employeesData.AddNew(model);
                }
                _employeesData.Commit();

                return RedirectToAction(nameof(Index));
            }
            //Если модель не валидна, возвращаем ее на представление
            return View(model);
        }

        //Удаление сотрудника
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            _employeesData.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}