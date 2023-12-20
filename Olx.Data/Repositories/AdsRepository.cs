using Olx.Data.DataContext;
using Olx.Data.Interfaces;
using Olx.Domain.Models;

namespace Olx.Data.Repositories;

public class AdsRepository : Repository<Ads>, IAdsInterface
{
    public AdsRepository(AppDb appDb) : base(appDb)
    {
    }
}
