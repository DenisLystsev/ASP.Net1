using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Models;
using WebStore.Infrastructure.Interfaces;

namespace WebStore.Infrastructure.Implementations
{
    //Реализация интерфейса IEmployeesData, хранит информацию в памяти
    public class InMemoryEmployeesData : IEmployeesData
    {
        private readonly List<EmployeeView> _employees;
        
        public InMemoryEmployeesData()
        {
            _employees =  new List<EmployeeView>
            {
                new EmployeeView
                {
                    Id = 1,
                    FirstName = "Иван",
                    Patronymic = "Иванович",
                    LastName = "Иванов",
                    Age = 37,
                    Position = "Директор"
                },
                new EmployeeView
                {
                    Id = 2,
                    FirstName = "Владислав",
                    Patronymic = "Степанович",
                    LastName = "Cтариков",
                    Age = 28,
                    Position = "Заместитель директора"
                }
            };
        }

        public IEnumerable<EmployeeView> GetAll()
        {
            return _employees;
        }

        public EmployeeView GetById(int id)
        {
            return _employees.FirstOrDefault(e => e.Id.Equals(id));
        }

        public void Commit()
        {

        }

        public void AddNew(EmployeeView model)
        {
            model.Id = _employees.Max(e => e.Id) + 1;
            _employees.Add(model);
        }

        public void Delete(int id)
        {
            var employee = GetById(id);
            if (employee!=null)
            {
                _employees.Remove(employee);
            }
        }
    }
}
