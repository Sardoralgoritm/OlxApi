namespace Olx.Domain.Models;

public class Message : BaseModel
{
    public string Text { get; set; } = string.Empty;
    public int ChatId { get; set; }
    public string UserId { get; set; } = string.Empty;
    public User User { get; set; } = new();
    public Chat Chat { get; set; } = new();
}
