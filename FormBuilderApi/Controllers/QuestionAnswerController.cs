using FormBuilder.Application.BuisnessInterfaces;
using FormBuilder.Data.ModelEntities;
using Microsoft.AspNetCore.Mvc;

namespace FormBuilderApi.Controllers
{
    [ApiController] // Add this to specify that it's an API controller
    [Route("api/[controller]")] // Route convention for API controllers
    public class QuestionAnswerController : Controller
    {
        private readonly IAnswersAyushService _answersAyushService;

        public QuestionAnswerController(IAnswersAyushService answersAyushService)
        {
            _answersAyushService = answersAyushService;
        }


        [HttpGet("allQuestions")]
        public ActionResult<List<QuestAnsModel>> GetList() // Use ActionResult for proper HTTP responses
        {
            var list = _answersAyushService.GetAll();
            return Ok(list); // Return 200 OK with the list
        }


    }
}
