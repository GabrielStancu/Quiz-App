using QuizApp.Models;
using System.Collections.Generic;

namespace QuizApp.Workers
{
    class QuestionPopulator
    {
        public static List<Question> AllQuestions;

        public QuestionPopulator() =>
            InitializeQuestions();

        private void InitializeQuestions()
        {
            AllQuestions.Add(new Question("1 + 1 = ?", QuestionType.Mathematics, new string[] { "3", "2", "-1", "0"}, 1));
            AllQuestions.Add(new Question("a^2 + b^2 = ?", QuestionType.Mathematics, new string[] { "2a + 2b", "ab", "c^2", "c"}, 2));
            AllQuestions.Add(new Question("E = ?", QuestionType.Physics, new string[] { "Euler", "m*c^2", "What?", "Error"}, 1));
            AllQuestions.Add(new Question("N / (m ^ 2) = ?", QuestionType.Physics, new string[] { "Pa", "J", "g", "m"}, 0));
            AllQuestions.Add(new Question("NaCl is...", QuestionType.Chemistry, new string[] { "Pepper", "A salt", "Cleaning solution", "An acid"}, 1));
            AllQuestions.Add(new Question("Acids and...", QuestionType.Chemistry, new string[] { "Non-acids", "Juices", "Water", "Bases"}, 3));
            AllQuestions.Add(new Question("The 100 years war lasted ... years.", QuestionType.History, new string[] { "100", "99", "116", "114"}, 2));
            AllQuestions.Add(new Question("Napoleon died in ...", QuestionType.History, new string[] { "1800", "1821", "1842", "1789"}, 1));
            AllQuestions.Add(new Question("The capital of Turkey is ...", QuestionType.Geography, new string[] { "Istanbul", "Constantinopol", "Bosfor", "Ankara"}, 3));
            AllQuestions.Add(new Question("The largest country in the world is ...", QuestionType.Geography, new string[] { "USA", "Great Britain", "Russia", "USA"}, 2));
            AllQuestions.Add(new Question("Van Gogh has sold ... paintings over his life.", QuestionType.Arts, new string[] { "50", "14", "3", "1"}, 3));
            AllQuestions.Add(new Question(@"The author of ""The Persistence of Memory"" is ...", QuestionType.Arts, new string[] { "Leonardo da Vinci", "Salvador Dali", "Van Gogh", "Unknown"}, 1));
        }
    }
}
