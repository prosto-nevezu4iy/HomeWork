using Dapper;
using Source.Interfaces;
using Source.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Source.Services
{
    public class DatabaseEmployeeService : IDatabaseEmployeeService, IService<Employee>
    {
        private const string DbConnString = "DefaultConnection";

        public void Add(Employee entity)
        {
            var sql = "INSERT INTO SomeTable (Name, Location, Job, Project) Values (@Name, @Location, @Job, @Project)";
            using (var connection = GetDbConnection())
            {
                connection.Execute(sql, entity);
            }
        }

        public IEnumerable<Employee> Get()
        {
            var sql = "SELECT * FROM SomeTable";

            using (var connection = GetDbConnection())
            {
                return connection.Query<Employee>(sql).AsEnumerable();
            }
        }

        public IDbConnection GetDbConnection()
        {
            var connection = new SqlConnection(DbConnString);
            connection.Open();
            return connection;
        }
    }
}
