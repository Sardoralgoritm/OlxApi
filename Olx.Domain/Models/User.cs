using Microsoft.AspNetCore.Identity;
using Olx.Domain.Enums;

namespace Olx.Domain.Models;

public class User : IdentityUser
{
    public string FirsName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public IsOnline IsOnline { get; set; }
    public DateTime LastOnline { get; set; }
    public ICollection<Ads> Adses { get; set; } = new List<Ads>();
    public ICollection<Chat> Chats { get; set; } = new List<Chat> { };
}
