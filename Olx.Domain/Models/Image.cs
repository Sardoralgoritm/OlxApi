namespace Olx.Domain.Models;

public class Image : BaseModel
{
    public string Url { get; set; } = string.Empty;
    public int AdsId { get; set; }
    public Ads Ads { get; set; } = new();
}
