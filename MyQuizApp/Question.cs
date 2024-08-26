using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQuizApp
{
    internal class Question
    {
        //#instructions:
        //1. Display Question
        //2. Provide Answers
        //3. Choose the correct answers

        //step1 -> prop
        public string QuestionText { get; set; }
        public string[] Answers { get; set; }
        public int CorrectAnswerIndex { get; set; }


        //step2 -> Constructor 
        public Question(string questionText, string[] answers, int correctAnswersIndex)
        {
            QuestionText = questionText; 
            Answers = answers; 
            CorrectAnswerIndex = correctAnswersIndex;
        }

        //step3 -> one bool method
        public bool IsCorrectAnswer(int choice) { 
            return CorrectAnswerIndex == choice;    
        }
    }
}
