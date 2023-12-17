namespace Olx.Domain.Models;

public class SubRegion : BaseModel
{
    public string Name { get; set; } = string.Empty;
    public int RegionId { get; set; }
    public Region Region { get; set; } = new();
    public List<Ads> Adses { get; set; } = new List<Ads> { };
}
