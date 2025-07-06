namespace ASP_Chat.Models;

public class Message
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string Content { get; set; }
    public DateTime SentAt { get; set; }
}
