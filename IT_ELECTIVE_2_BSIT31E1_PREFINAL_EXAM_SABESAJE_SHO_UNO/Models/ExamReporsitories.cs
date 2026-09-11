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
                new ExamQuestion {
                    Id = 9,
                    QuestionText = "What is the purpose of a navigation property such as public Section Section { get; set; }?",
                    Options = new List<string>{ "A. It stores the database password", "B. It represents a relationship to another entity", "C. It creates a new database", "D. It validates the student's name" },
                    CorrectAnswer = "B. It represents a relationship to another entity",
                    Explanation = "Navigation properties allow traversing relationships between related entities in EF Core."
                },
                new ExamQuestion {
                    Id = 10,
                    QuestionText = "What does .Include() generally allow EF Core to do?",
                    Options = new List<string>{ "A. Delete the Section table", "B. Load related Section data together with Students", "C. Create a new Student", "D. Validate Student input" },
                    CorrectAnswer = "B. Load related Section data together with Students",
                    Explanation = ".Include() specifies related data to be included in query results (eager loading)."
                },
                new ExamQuestion {
                    Id = 11,
                    QuestionText = "Why might a ViewModel be used when displaying Student and Section information?",
                    Options = new List<string>{ "A. To replace the database", "B. To combine or shape the data specifically needed by the view", "C. To automatically create database tables", "D. To prevent controllers from using LINQ" },
                    CorrectAnswer = "B. To combine or shape the data specifically needed by the view",
                    Explanation = "ViewModels custom-tailor data for view presentation without exposing raw domain models."
                },
                new ExamQuestion {
                    Id = 12,
                    QuestionText = "What is the main benefit of Include(s => s.Section)?",
                    Options = new List<string>{ "A. It loads the related Section navigation property", "B. It creates a Section object manually", "C. It removes the foreign key", "D. It prevents the query from accessing the database" },
                    CorrectAnswer = "A. It loads the related Section navigation property",
                    Explanation = "It ensures that the Section details associated with each student are fetched alongside."
                },
                new ExamQuestion {
                    Id = 13,
                    QuestionText = "Which type of validation occurs in the browser before a request is sent to the server?",
                    Options = new List<string>{ "A. Database-level validation", "B. Client-side validation", "C. Server-side validation", "D. EF Core migration validation" },
                    CorrectAnswer = "B. Client-side validation",
                    Explanation = "Client-side validation runs via JavaScript/HTML attributes directly in the browser."
                },
                new ExamQuestion {
                    Id = 14,
                    QuestionText = "Why is server-side validation still necessary if client-side validation exists?",
                    Options = new List<string>{ "A. Client-side validation can be bypassed", "B. Client-side validation automatically modifies the database", "C. Server-side validation only works with SQLite", "D. Client-side validation cannot display messages" },
                    CorrectAnswer = "A. Client-side validation can be bypassed",
                    Explanation = "Client-side scripts can be disabled or altered by users, making server-side validation crucial for security."
                },
                new ExamQuestion {
                    Id = 15,
                    QuestionText = "A school requires every student to have a unique Student Number. Which rule best represents this requirement?",
                    Options = new List<string>{ "A. Student Number should always be nullable", "B. Student Number should be unique", "C. Student Number should always be the same", "D. Student Number should contain only spaces" },
                    CorrectAnswer = "B. Student Number should be unique",
                    Explanation = "Uniqueness ensures no two records collide on critical identifiers."
                },


