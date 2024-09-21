using FormBuilder.Application.BuisnessInterfaces;
using FormBuilder.Core.DBEntities;
using FormBuilder.Data.ModelEntities;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace FormBuilderApi.Controllers
{
    [ApiController] // Add this to specify that it's an API controller
    [Route("api/[controller]")] // Route convention for API controllers
    public class QuestionAnswerController : Controller
    {
        private readonly IAnswersAyushService _answersAyushService;
        private readonly IQuestionsAyushService _questionsAyushService;

        public QuestionAnswerController(IAnswersAyushService answersAyushService, IQuestionsAyushService questionsAyushService)
        {
            _answersAyushService = answersAyushService;
            _questionsAyushService = questionsAyushService;
        }


        [HttpGet("allQuestions")]
        public ActionResult<List<QuestAnsModel>> GetList() // Use ActionResult for proper HTTP responses
        {
            var list = _answersAyushService.GetAll();
            return Ok(list); // Return 200 OK with the list
        }

        [HttpGet("singleQuestion")]
        public ActionResult<List<QuestAnsModel>> GetSingle(int questionId) // Use ActionResult for proper HTTP responses
        {
            var list = _answersAyushService.GetSingle(questionId);
            return Ok(list); // Return 200 OK with the list
        }

        [HttpPost("insertAnswers")]
        public ActionResult InsertAnswers([FromBody] AnswersAyush[] answers) // Use ActionResult for proper HTTP responses
        {   
            _answersAyushService.insertAnswers(answers);
            return Ok("Answers Added Successfully");
        }

        [HttpPost("insertQuestion")]
        public ActionResult<object> InsertQuestion([FromBody] QuestionsAyush questions) // Use ActionResult for proper HTTP responses
        {
            _questionsAyushService.insertQuestion(questions);
            return Ok(new { questionId = questions.questionId });
        }

        [HttpPost("insertQuestionAnswer")]
        public ActionResult InsertQuestionAnswer([FromBody] MainModel model) // Use ActionResult for proper HTTP responses
        {

            var question = _questionsAyushService.insertQuestion(model.questionsAyush);

            var answers = model.answersAyush;
            for(int i = 0;i<answers.Length;i++)
                answers[i].questionId = question.questionId;
            _answersAyushService.insertAnswers(answers);

            return Ok(new { message = "Question and Answers Added Successfully", questionId = question.questionId });
        }

    }
}
