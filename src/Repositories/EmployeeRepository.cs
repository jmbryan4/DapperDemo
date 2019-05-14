using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using DapperDemo.Models;
using Microsoft.Extensions.Configuration;

namespace DapperDemo.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly IConfiguration _config;

        public EmployeeRepository(IConfiguration config)
        {
            _config = config;
        }

        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(_config.GetConnectionString("MyConnectionString"));
            }
        }

        public async Task<Employee> Get(int id)
        {
            using (IDbConnection conn = Connection)
            {
                string sqlQuery = "SELECT Id, FirstName, LastName, Email FROM Employee WHERE Id = @Id";
                conn.Open();
                var result = await conn.QueryAsync<Employee>(sqlQuery, new { Id = id });
                return result.FirstOrDefault();
            }
        }

        public async Task<List<Employee>> GetByEmail(string email)
        {
            using (IDbConnection conn = Connection)
            {
                string sql = $@"
                        SELECT
                            {nameof(Employee.Id)},
                            {nameof(Employee.FirstName)},
                            {nameof(Employee.LastName)},
                            {nameof(Employee.Email)}
                        FROM {nameof(Employee)}
                        WHERE {nameof(Employee.Email)} = @{nameof(email)};";
                conn.Open();
                var result = await conn.QueryAsync<Employee>(sql, new { Email = email });
                return result.ToList();
            }
        }
    }
}
