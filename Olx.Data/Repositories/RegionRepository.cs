using Olx.Data.DataContext;
using Olx.Data.Interfaces;
using Olx.Domain.Models;

namespace Olx.Data.Repositories;

public class RegionRepository : Repository<Region>, IRegionInterface
{
    public RegionRepository(AppDb appDb) : base(appDb)
    {
    }
}
