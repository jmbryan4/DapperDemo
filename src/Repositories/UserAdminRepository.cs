using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using DapperDemo.Models.UserAdmin;
using Microsoft.Extensions.Configuration;

namespace DapperDemo.Repositories
{
    public class UserAdminRepository : IUserAdminRepository
    {
        private readonly IConfiguration _config;

        public UserAdminRepository(IConfiguration config)
        {
            _config = config;
        }

        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(_config.GetConnectionString("CronusUserAdmin"));
            }
        }

        public async Task<List<User>> GetUsersByAccount(string account)
        {
            using (IDbConnection conn = Connection)
            {
                string sql = $@"SELECT {nameof(User.Id)},
                               {nameof(User.Account)},
                               {nameof(User.PreferredLanguage)},
                               {nameof(User.Email)}
                            FROM [{nameof(User)}]
                            WHERE {nameof(User.Account)} = @Account;";
                conn.Open();
                var result = await conn.QueryAsync<User>(sql, new { Account = account });
                return result.ToList();
            }
        }
    }
}
