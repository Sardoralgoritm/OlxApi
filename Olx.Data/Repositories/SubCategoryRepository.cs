using Olx.Data.DataContext;
using Olx.Data.Interfaces;
using Olx.Domain.Models;

namespace Olx.Data.Repositories;

public class SubCategoryRepository : Repository<SubCategory>, ISubCategoryInterface
{
    public SubCategoryRepository(AppDb appDb) : base(appDb)
    {
    }
}
