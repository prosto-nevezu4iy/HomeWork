using Source.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Source.Interfaces
{
    public interface IFileEmployeeService : IService<Employee>
    {
        IList<Employee> GetEmployeesFromFIle();
    }
}
