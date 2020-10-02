using Source.Interfaces;
using Source.Models;
using Source.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Source.Strategy
{
    public class EmployeeServiceStrategy
    {
        private IService<Employee> _employeeService;

        public EmployeeServiceStrategy(EmployeeSourceType sourceType)
        {
            _employeeService = GetService(sourceType);
        }

        public void SetStrategy(EmployeeSourceType sourceType)
        {
            _employeeService = GetService(sourceType);
        }

        public void DoServiceJob(EmployeeOperationType operationType)
        {
            if (operationType == EmployeeOperationType.Add)
            {
                var employeToAdd = new Employee
                {
                    Name = "Alexandr",
                    Location = "Chisinau",
                    Job = ".Net Intern",
                    Project = "ACI"
                };
                _employeeService.Add(employeToAdd);
            }
            else if (operationType == EmployeeOperationType.Get)
            {
                IEnumerable<Employee> employees = _employeeService.Get();
                foreach (var employee in employees)
                {
                    Console.WriteLine(employee.Name);
                }
            }
        }

        private IService<Employee> GetService(EmployeeSourceType sourceType)
        {
            var dependencyConfig = new Dictionary<EmployeeSourceType, IService<Employee>>
            {
                { EmployeeSourceType.Memory, new MemoryEmployeeService() },
                { EmployeeSourceType.File, new FileEmployeeService() },
                { EmployeeSourceType.Database, new DatabaseEmployeeService() },
            };

            return dependencyConfig[sourceType];
        }
    }
}
