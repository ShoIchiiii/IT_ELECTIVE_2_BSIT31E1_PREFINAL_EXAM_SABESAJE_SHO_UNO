using IT_ELECTIVE_2_SECTION_PREFINAL_EXAM_Lastname_FirstName.Models;
using IT_ELECTIVE_2_SECTION_PREFINAL_EXAM_Lastname_FirstName.Services;
using Microsoft.AspNetCore.Mvc;

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