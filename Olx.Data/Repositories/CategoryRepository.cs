using Olx.Data.DataContext;
using Olx.Data.Interfaces;
using Olx.Domain.Models;

namespace Olx.Data.Repositories;

public class CategoryRepository : Repository<Category>, ICategoryInterface
{
    public CategoryRepository(AppDb appDb) : base(appDb)
    {
    }
}
