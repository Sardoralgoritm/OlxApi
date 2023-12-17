namespace Olx.Domain.Models;

public class Region : BaseModel
{
    public string Name { get; set; } = string.Empty;
    public List<SubRegion> SubRegions { get; set; } = new List<SubRegion>();
}
