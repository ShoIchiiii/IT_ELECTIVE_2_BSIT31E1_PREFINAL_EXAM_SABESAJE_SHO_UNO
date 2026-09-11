using Microsoft.AspNetCore.Mvc;
using IT_ELECTIVE_2_BSIT31E1_PREFINAL_EXAM_S.Models;

namespace IT_ELECTIVE_2_BSIT31E1_PREFINAL_EXAM_S.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var questions = ExamRepository.GetQuestions();
            return View(questions);
        }
    }
}