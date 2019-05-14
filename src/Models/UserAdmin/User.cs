using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperDemo.Models.UserAdmin
{
    public class User
    {
        public long Id { get; set; }
        public string Email { get; set; }
        public string Account { get; set; }
        public string PreferredLanguage { get; set; }
    }
}
