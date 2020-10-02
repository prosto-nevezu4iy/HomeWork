using Source.Interfaces;
using Source.Models;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;

namespace Source.Services
{
    public class FileEmployeeService : IFileEmployeeService, IService<Employee>
    {
        private const string File = "@test.json";

        public void Add(Employee entity)
        {
            var employees = GetEmployeesFromFIle();
            employees.Add(entity);
            System.IO.File.WriteAllText(File, JsonConvert.SerializeObject(employees));
        }

        public IEnumerable<Employee> Get()
        {
            return GetEmployeesFromFIle().AsEnumerable();
        }

        public IList<Employee> GetEmployeesFromFIle()
        {
            return JsonConvert.DeserializeObject<List<Employee>>(System.IO.File.ReadAllText(File));
        }
    }
}
