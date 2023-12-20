using Olx.Data.DataContext;
using Olx.Data.Interfaces;
using Olx.Domain.Models;

namespace Olx.Data.Repositories;

public class MessageRepository : Repository<Message>, IMessageInterface
{
    public MessageRepository(AppDb appDb) : base(appDb)
    {
    }
}
