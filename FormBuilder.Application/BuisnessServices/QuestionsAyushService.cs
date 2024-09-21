using FormBuilder.Application.BuisnessInterfaces;
using FormBuilder.Core;
using FormBuilder.Core.DBEntities;

namespace FormBuilder.Application.BuisnessServices
{
    public class QuestionsAyushService : IQuestionsAyushService
    {
        private readonly InboxContext _dbContext;

        public QuestionsAyushService(InboxContext inboxContext)
        {
            _dbContext = inboxContext;
        }

        public QuestionsAyush insertQuestion(QuestionsAyush question)
        {
            _dbContext.QuestionsAyush.Add(question);
            _dbContext.SaveChanges();
            return question;
        }
    }
}
