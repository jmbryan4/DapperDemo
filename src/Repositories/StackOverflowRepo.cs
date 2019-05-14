using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using DapperDemo.Models.StackOverflow;
using Microsoft.Extensions.Configuration;

namespace DapperDemo.Repositories
{
    public class StackOverflowRepo : IStackOverflowRepo
    {
        private readonly IConfiguration _config;

        public StackOverflowRepo(IConfiguration config)
        {
            _config = config;
        }

        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(_config.GetConnectionString("StackOverflow"));
            }
        }

        public async Task<List<TopAnswerer>> GetTopAnswerers(int top)
        {
            using (IDbConnection conn = Connection)
            {
                conn.Open();
                var result = await conn.QueryAsync<TopAnswerer>("GetTopAnswerers", new { Top = top }, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }
    }
}
