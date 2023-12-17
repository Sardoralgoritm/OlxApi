using Olx.Domain.Enums;

namespace Olx.Domain.Models;

public class Ads : BaseModel
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public State State { get; set; }
    public DateTime CreateAt { get; set; }
    public DateTime SellAt { get; set; }
    public string UserId { get; set; } = string.Empty;
    public int SubRegionId { get; set; }
    public int SubCategoryId { get; set; }
    public User User { get; set; } = new();
    public SubCategory SubCategory { get; set; } = new();
    public SubRegion SubRegion { get; set; } = new();
    public List<Image> Images { get; set; } = new List<Image>();
}
