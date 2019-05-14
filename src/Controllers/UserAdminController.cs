using System.Collections.Generic;
using System.Threading.Tasks;
using DapperDemo.Models.UserAdmin;
using DapperDemo.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DapperDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserAdminController : ControllerBase
    {
        private readonly IUserAdminRepository _userAdminRepository;

        public UserAdminController(IUserAdminRepository userAdminRepository)
        {
            _userAdminRepository = userAdminRepository;
        }

        [HttpGet]
        [Route("account/{account}")]
        public async Task<ActionResult<List<User>>> Get(string account)
        {
            return await _userAdminRepository.GetUsersByAccount(account);
        }
    }
}
