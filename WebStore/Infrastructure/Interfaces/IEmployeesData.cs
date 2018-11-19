using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Models;

namespace WebStore.Infrastructure.Interfaces
{
    //Интерфейс для работы с сотрудниками

    public interface IEmployeesData
    {
        //Получение списка сотрудников
        IEnumerable<EmployeeView> GetAll();

        //Получение сотрудника по Id
        EmployeeView GetById(int id);

        //Сохранить изменения
        void Commit();

        //Добавить нового сотрудника
        void AddNew(EmployeeView model);

        //Удалить сотрудника
        void Delete(int id);
    }
}
