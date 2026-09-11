using IT_ELECTIVE_2_SECTION_PREFINAL_EXAM_Lastname_FirstName.Models;

namespace IT_ELECTIVE_2_SECTION_PREFINAL_EXAM_Lastname_FirstName.Services
{
    public static class ExamRepository
    {
        public static List<ExamQuestion> GetQuestions()
        {
            return new List<ExamQuestion>
            {
                new ExamQuestion {
                    Id = 1,
                    QuestionText = "What is the main problem solved by using a database instead of an in-memory collection?",
                    Options = new List<string>{ "A. It makes C# code shorter", "B. It prevents the application from restarting", "C. It allows data to persist after the application stops", "D. It removes the need for MVC" },
                    CorrectAnswer = "C. It allows data to persist after the application stops",
                    Explanation = "Databases provide persistent storage, allowing data to be retained even after the application stops or restarts."
                },
                new ExamQuestion {
                    Id = 2,
                    QuestionText = "Which approach is being used when an existing database is used to generate EF Core entity classes?",
                    Options = new List<string>{ "A. Code-First", "B. Database-First", "C. Model-First", "D. Controller-First" },
                    CorrectAnswer = "B. Database-First",
                    Explanation = "Database-First approach generates code models and DbContext directly from an existing database schema."
                },