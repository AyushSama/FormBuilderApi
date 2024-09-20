using Microsoft.EntityFrameworkCore;

namespace FormBuilder.Core
{
    public class InboxContext(DbContextOptions<InboxContext> options) : DbContext(options)
    {

    }
}
