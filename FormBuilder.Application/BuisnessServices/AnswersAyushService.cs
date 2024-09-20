using FormBuilder.Application.BuisnessInterfaces;
using FormBuilder.Core;
using FormBuilder.Data.ModelEntities;
using Microsoft.EntityFrameworkCore;

namespace FormBuilder.Application.BuisnessServices
{
    public class AnswersAyushService : IAnswersAyushService
    {

        private readonly InboxContext _dbContext;

        public AnswersAyushService(InboxContext inboxContext)
        {
            _dbContext = inboxContext;
        }

        public List<QuestAnsModel> GetAll()
        {
            var result = from q in _dbContext.QuestionsAyush
                         join a in _dbContext.AnswersAyush on q.questionId equals a.questionId
                         select new QuestAnsModel
                         {
                             question = q.question,
                             answerOption = a.answerOption,
                             answer = a.answer,
                             correct = a.correct
                         };

            return result.ToList();
        }

        public List<QuestAnsModel> GetSingle(int questionId)
        {
            var result = from q in _dbContext.QuestionsAyush
                         join a in _dbContext.AnswersAyush on q.questionId equals a.questionId
                         where q.questionId == questionId
                         select new QuestAnsModel
                         {
                             question = q.question,
                             answerOption = a.answerOption,
                             answer = a.answer,
                             correct = a.correct
                         };

            return result.ToList();
        }

    }
}
