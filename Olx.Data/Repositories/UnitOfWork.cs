using Olx.Data.DataContext;
using Olx.Data.Interfaces;

namespace Olx.Data.Repositories;

public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly AppDb _appDb;
    public UnitOfWork(AppDb appDb)
    {
        _appDb = appDb;
        Ads = new AdsRepository(appDb);
        Category = new CategoryRepository(appDb);
        Chat = new ChatRepository(appDb);
        Image = new ImageRepository(appDb);
        Message = new MessageRepository(appDb);
        Region = new RegionRepository(appDb);
        SubCategory = new SubCategoryRepository(appDb);
        Subregion = new SubRegionRepository(appDb);
    }
    public IAdsInterface Ads { get; }
    public ICategoryInterface Category { get; }
    public IChatInterface Chat { get; }
    public IImageInterface Image { get; }
    public IMessageInterface Message { get; }
    public IRegionInterface Region { get; }
    public ISubCategoryInterface SubCategory {  get; }
    public ISubRegionInterface Subregion { get; }
    public void Dispose() => GC.SuppressFinalize(this);
    public async Task SaveChangesAsync()
    {
        await _appDb.SaveChangesAsync();
    }
}
