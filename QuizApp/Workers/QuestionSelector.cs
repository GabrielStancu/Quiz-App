using QuizApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuizApp.Workers
{
    class QuestionSelector
    {
        public HashSet<Question> Questions;

        public HashSet<Question> SelectQuestions(List<QuestionType> questionTypes)
        {
            GetQuestionsByCathegory(questionTypes);

            return Questions;
        }

        private void GetQuestionsByCathegory(List<QuestionType> questionTypes)
        {
            List<Question> questions = QuestionPopulator.AllQuestions;
            questions = questions.Where(q => questionTypes.Contains(q.Cathegory)).ToList();
            Questions = new HashSet<Question>(questions);
        }
    }
}
