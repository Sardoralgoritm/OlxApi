using Olx.Data.DataContext;
using Olx.Data.Interfaces;
using Olx.Domain.Models;

namespace Olx.Data.Repositories;

public class ImageRepository : Repository<Image>, IImageInterface
{
    public ImageRepository(AppDb appDb) : base(appDb)
    {
    }
}
