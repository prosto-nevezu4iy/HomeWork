using Source.Interfaces;
using Source.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Source.Services
{
    public class MemoryEmployeeService : IService<Employee>
    {
        public readonly List<Employee> employees;

        public MemoryEmployeeService()
        {
            employees = new List<Employee>();
        }

        public void Add(Employee entity)
        {
            employees.Add(entity);
        }

        public IEnumerable<Employee> Get()
        {
            return employees.AsEnumerable();
        }
    }
}
