using System.Collections.Generic;

namespace QuizApp.Models
{
    class Quiz
    {
        public List<Question> Questions { get; private set; }
        public List<int> Answers { get; private set; }
        public int Score { get; private set; }

        public static readonly int MaxQuestions = 20; 

        public Quiz() =>
            (Questions, Answers, Score) = (new List<Question>(MaxQuestions), new List<int>(MaxQuestions), 0);

        internal void AddQuestion(Question question) =>
            Questions.Add(question);

        public int ComputeScore()
        {
            for(int qNr = 0; qNr < MaxQuestions; qNr++)
            {
                if(Questions[qNr].IsCorrectAnswer(Answers[qNr]))
                {
                    Score++;
                }
            }

            return Score;
        }
   
    }
}
