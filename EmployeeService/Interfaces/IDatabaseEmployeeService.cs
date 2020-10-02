using Source.Models;
using System.Data;
using System.Data.SqlClient;

namespace Source.Interfaces
{
    public interface IDatabaseEmployeeService : IService<Employee>
    {
        IDbConnection GetDbConnection();
    }
}
