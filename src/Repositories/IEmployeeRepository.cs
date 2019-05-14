using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DapperDemo.Models;

namespace DapperDemo.Repositories
{
    public interface IEmployeeRepository
    {
        Task<Employee> Get(int id);
        Task<List<Employee>> GetByEmail(string email);
    }
}
