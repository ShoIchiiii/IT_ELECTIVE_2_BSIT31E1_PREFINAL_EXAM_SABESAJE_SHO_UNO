namespace IT_ELECTIVE_2_SECTION_PREFINAL_EXAM_Lastname_FirstName.Models
{
    public class ExamQuestion
    {
        public int Id { get; set; }
        public string QuestionText { get; set; } = string.Empty;
        public List<string> Options { get; set; } = new List<string>();
        public string CorrectAnswer { get; set; } = string.Empty;
        public string Explanation { get; set; } = string.Empty;
    }
}