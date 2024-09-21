using FormBuilder.Core.DBEntities;
using FormBuilder.Data.ModelEntities;

namespace FormBuilder.Application.BuisnessInterfaces
{
    public interface IAnswersAyushService
    {

        public List<QuestAnsModel> GetAll();

        public List<QuestAnsModel> GetSingle(int questionId);

        public void insertAnswers(AnswersAyush[] answers);


    }
}
