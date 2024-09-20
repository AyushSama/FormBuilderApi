using FormBuilder.Core.DBEntities;
using Microsoft.EntityFrameworkCore;

namespace FormBuilder.Core
{
    public class InboxContext(DbContextOptions<InboxContext> options) : DbContext(options)
    {
        public DbSet<AnswersAyush> AnswersAyush { get; set; }

        public DbSet<QuestionsAyush> QuestionsAyush { get; set; }
    }
}
