using System;

namespace QuizApp.Models
{
    enum QuestionType
    {
        Mathematics, 
        Physics, 
        Chemistry, 
        History, 
        Geography, 
        Arts
    }
    class Question
    {
        public string Text { get; private set; }
        public QuestionType Cathegory { get; private set; }
        public string[] Answers { get; private set; }
        public int CorrectAnswerIndex { get; private set; }

        public Question(string text, QuestionType cathegory, string[] answers, int correctAnswerIndex) =>
            (Text, Cathegory, Answers, CorrectAnswerIndex) = (text, cathegory, answers, correctAnswerIndex);

        public bool IsCorrectAnswer(int index) =>
            index == CorrectAnswerIndex;
    }
}
