using Microsoft.AspNetCore.Mvc;

namespace FormBuilderApi.Controllers
{
    [ApiController]
    public class QuestionAnswerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
