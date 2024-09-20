using FormBuilder.Core;

namespace FormBuilder.Application.BuisnessServices
{
    public class QuestionsAyushService
    {
        private readonly InboxContext _dbContext;

        public QuestionsAyushService(InboxContext inboxContext)
        {
            _dbContext = inboxContext;
        }
    }
}
