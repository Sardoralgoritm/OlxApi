using Olx.Data.DataContext;
using Olx.Data.Interfaces;
using Olx.Domain.Models;

namespace Olx.Data.Repositories;

public class ChatRepository : Repository<Chat>, IChatInterface
{
    public ChatRepository(AppDb appDb) : base(appDb)
    {
    }
}
