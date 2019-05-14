using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperDemo.Models.StackOverflow
{
    public class User
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public string DisplayName { get; set; }
        public int DownVotes { get; set; }
        public DateTime LastAccessDate { get; set; }
        public string Location { get; set; }
        public int Reputation { get; set; }
        public int UpVotes { get; set; }
        public int Views { get; set; }
    }
}
