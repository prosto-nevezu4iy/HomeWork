using Source.Models;
using Source.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeService
{
    class Program
    {
        static void Main(string[] args)
        {
            args = "Memory Get".Split();
            EmployeeSourceType sourceType;
            Enum.TryParse(args[0], out sourceType);

            EmployeeOperationType operationType;
            Enum.TryParse(args[1], out operationType);

            var employeeService = new EmployeeServiceStrategy(sourceType);

            employeeService.DoServiceJob(operationType);
        }
    }
}
