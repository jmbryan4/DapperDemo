using System.Collections.Generic;
using System.Threading.Tasks;
using DapperDemo.Models.StackOverflow;
using DapperDemo.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DapperDemo.Controllers
{
    [Route("api/so")]
    [ApiController]
    public class StackOverflowController : ControllerBase
    {
        private readonly IStackOverflowRepo _stackOverflowRepo;

        public StackOverflowController(IStackOverflowRepo stackOverflowRepo)
        {
            _stackOverflowRepo = stackOverflowRepo;
        }

        [HttpGet]
        [Route("topanswerers/{number}")]
        public async Task<ActionResult<List<TopAnswerer>>> Get(int number)
        {
            return await _stackOverflowRepo.GetTopAnswerers(number);
        }
    }
}
