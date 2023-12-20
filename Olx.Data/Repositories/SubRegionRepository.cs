using Olx.Data.DataContext;
using Olx.Data.Interfaces;
using Olx.Domain.Models;

namespace Olx.Data.Repositories;

public class SubRegionRepository : Repository<SubRegion>, ISubRegionInterface
{
    public SubRegionRepository(AppDb appDb) : base(appDb)
    {
    }
}
