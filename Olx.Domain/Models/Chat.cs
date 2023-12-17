namespace Olx.Domain.Models;

public class Chat : BaseModel
{
    public string User1Id { get; set; } = string.Empty;
    public string User2Id { get; set; } = string.Empty;
    public User User { get; set; } = new User();
    public List<Chat> Chats { get; set; } = new List<Chat>();
}
