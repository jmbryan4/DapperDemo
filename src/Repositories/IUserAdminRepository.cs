using System.Collections.Generic;
using System.Threading.Tasks;
using DapperDemo.Models.UserAdmin;

namespace DapperDemo.Repositories
{
    public interface IUserAdminRepository
    {
        Task<List<User>> GetUsersByAccount(string account);
    }
}
