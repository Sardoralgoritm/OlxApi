namespace Olx.Data.Interfaces;

public interface IUnitOfWork
{
    public IAdsInterface Ads { get; }
    public ICategoryInterface Category { get; }
    public IChatInterface Chat { get; }
    public IImageInterface Image { get; }
    public IMessageInterface Message { get; }
    public IRegionInterface Region { get; }
    public ISubCategoryInterface SubCategory { get; }
    public ISubRegionInterface Subregion { get; }

    Task SaveChangesAsync();
}
