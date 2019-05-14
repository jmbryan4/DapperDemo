namespace DapperDemo.Models.StackOverflow
{
    public class TopAnswerer
    {
        public int UserId { get; set; }
        public string DisplayName { get; set; }
        public int Answers { get; set; }
        public decimal AverageAnswerScore { get; set; }
    }
}
