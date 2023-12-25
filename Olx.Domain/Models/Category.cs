namespace Olx.Domain.Models;

public class Category : BaseModel
{
    public string Name { get; set; } = string.Empty;
    public ICollection<SubCategory> SubCategories { get; set; } = new List<SubCategory>();
}
