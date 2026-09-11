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
                new ExamQuestion {
                    Id = 3,
                    QuestionText = "What is the primary purpose of Entity Framework Core?",
                    Options = new List<string>{ "A. To create HTML pages automatically", "B. To replace the MVC Controller", "C. To map objects in code to relational database data", "D. To replace the C# compiler" },
                    CorrectAnswer = "C. To map objects in code to relational database data",
                    Explanation = "EF Core is an Object-Relational Mapper (ORM) that bridges the gap between C# objects and database tables."
                },
                new ExamQuestion {
                    Id = 3,
                    QuestionText = "What is the primary purpose of Entity Framework Core?",
                    Options = new List<string>{ "A. To create HTML pages automatically", "B. To replace the MVC Controller", "C. To map objects in code to relational database data", "D. To replace the C# compiler" },
                    CorrectAnswer = "C. To map objects in code to relational database data",
                    Explanation = "EF Core is an Object-Relational Mapper (ORM) that bridges the gap between C# objects and database tables."
                },
                new ExamQuestion {
                    Id = 4,
                    QuestionText = "Which EF Core component is primarily responsible for communicating with the database?",
                    Options = new List<string>{ "A. DbContext", "B. DbSetView", "C. ControllerContext", "D. RazorContext" },
                    CorrectAnswer = "A. DbContext",
                    Explanation = "DbContext manages database connections, change tracking, and queries."
                },
                new ExamQuestion {
                    Id = 5,
                    QuestionText = "What does the command 'dotnet ef dbcontext scaffold...' primarily do?",
                    Options = new List<string>{ "A. Deletes the database", "B. Creates a new MVC project", "C. Generates EF Core models and a DbContext from an existing database", "D. Starts the MVC application" },
                    CorrectAnswer = "C. Generates EF Core models and a DbContext from an existing database",
                    Explanation = "Scaffolding reads an existing database schema and generates the corresponding classes and context."
                },
                new ExamQuestion {
                    Id = 6,
                    QuestionText = "Where is a database connection string commonly stored in an ASP.NET Core MVC application?",
                    Options = new List<string>{ "A. Program.cs only", "B. appsettings.json", "C. Index.cshtml", "D. Student.cs" },
                    CorrectAnswer = "B. appsettings.json",
                    Explanation = "Application configurations like connection strings are best kept in appsettings.json."
                },
                new ExamQuestion {
                    Id = 7,
                    QuestionText = "A Student belongs to exactly one Section, while a Section can contain many students. What type of relationship is this?",
                    Options = new List<string>{ "A. One-to-One", "B. One-to-Many", "C. Many-to-Many", "D. Many-to-One only" },
                    CorrectAnswer = "B. One-to-Many",
                    Explanation = "One Section has multiple Students (1:N)."
                },
                new ExamQuestion {
                    Id = 8,
                    QuestionText = "In the example 'public int SectionId { get; set; }', what is SectionId?",
                    Options = new List<string>{ "A. Primary key of Student", "B. Foreign key referencing Section", "C. Navigation property", "D. Database connection string" },
                    CorrectAnswer = "B. Foreign key referencing Section",
                    Explanation = "SectionId holds the foreign key value pointing to the primary key of the Section table."
                },
