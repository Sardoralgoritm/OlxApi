namespace Olx.Domain.Models;

public class SubCategory : BaseModel
{
    public string Name { get; set; } = string.Empty;
    public int CategoryId { get; set; }
    public Category Category { get; set; } = new();
    public List<Ads> Adses { get; set; } = new List<Ads>();
}
