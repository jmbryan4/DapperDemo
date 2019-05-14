using System.Collections.Generic;
using System.Threading.Tasks;
using DapperDemo.Models;
using DapperDemo.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DapperDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepo;

        public EmployeeController(IEmployeeRepository employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<Employee>> Get(int id)
        {
            return await _employeeRepo.Get(id);
        }

        [HttpGet]
        [Route("email/{email}")]
        public async Task<ActionResult<List<Employee>>> Get(string email)
        {
            return await _employeeRepo.GetByEmail(email);
        }
    }
}
