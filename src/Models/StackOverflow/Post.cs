using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperDemo.Models.StackOverflow
{
    public class Post
    {
        public int Id { get; set; }
        public int AcceptedAnswerId { get; set; }
        public int AnswerCount { get; set; }
        public int CommentCount { get; set; }
        public DateTime CreationDate { get; set; }
        public int FavoriteCount { get; set; }
        public DateTime LastActivityDate { get; set; }
        public DateTime LastEditDate { get; set; }
        public string LastEditorDisplayName { get; set; }
        public int LastEditorUserId { get; set; }
        public int OwnerUserId { get; set; }
        public int Score { get; set; }
        public string Tags { get; set; }
        public string Title { get; set; }
        public int ViewCount { get; set; }
    }
}
