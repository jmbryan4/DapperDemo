using System.Collections.Generic;
using System.Threading.Tasks;
using DapperDemo.Models.StackOverflow;

namespace DapperDemo.Repositories
{
    public interface IStackOverflowRepo
    {
        /// <summary>
        /// Get Top x number of answerers on the Stack Overflow 2010 site
        /// </summary>
        /// <param name="top">top number of users to get</param>
        Task<List<TopAnswerer>> GetTopAnswerers(int top);
    }
}
