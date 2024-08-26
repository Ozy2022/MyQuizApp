using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQuizApp
{
    //step4
    //1. Knows the questions that will display
    //2. The score that we will collect
    internal class Quiz
    {

        //step5
        private Question[] _questions;

        //step6
        public Quiz(Question[] questions)
        {
            /*
            So, what {this} keyword does is essentially tell the program, 
            'I want you to use the variable called **questions** that 
            belongs to the class **Quiz** and not the one that 
            belongs to the parameter you're passing to me.'"
             */

            this._questions = questions;
            //10-> here setting the score at 0;
            _score = 0;
        }


        //step10 Displaying the results
        //total scoer
        private int _score;

        //step9 Displaying Multiple Questions and
        //if we are right or wrong
        public void StartQuiz()
        {
            Console.WriteLine("Welcome to the Quiz!");
            int questionNumer = 1;

            //go throghe each question from 1 to 4
            foreach (Question question in _questions)
            {
                Console.WriteLine($"Question {questionNumer++}:");
                DisplayQuestion(question);
                int userChoice = GetUserChoice();
                if (question.IsCorrectAnswer(userChoice))
                {
                    Console.WriteLine("Correct!");
                    //10-> increment the score by 1
                    _score++; 
                } else
                {
                    Console.WriteLine($"Wrong!, The correct answer was: {question.Answers[question.CorrectAnswerIndex]}");
                }
            }
            DisplayResults();

        }


        //10-> method to display the results
        public void DisplayResults() 
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                 Results                                 ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════╝");
            Console.ResetColor();

            Console.WriteLine($"Quiz finished. Yor score is: {_score} out of {_questions.Length}");

            double precentage = (double)_score / _questions.Length;
            if(precentage >= 0.8)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Excellent Work!");

            } else if (precentage >= 0.5)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Good effort!");
            } else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Keep practicing!");
            }
            Console.ResetColor();
        }

        //step7 -> we need method to display the questions
        private void DisplayQuestion(Question question)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                 Question                                ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════╝");
            Console.ResetColor();

            Console.WriteLine(question.QuestionText);

            //here we will make a loop to go throgh all
            //the answers and display them
            //ForegroundColor is the text color of the console

            for (int i = 0; i < question.Answers.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("     ");
                Console.Write(i + 1);
                Console.ResetColor();
                Console.WriteLine($". {question.Answers[i]}");
            }


            //after we made StartQuiz method we can get rid of this code
            /*if (GetUserChoice() == question.CorrectAnswerIndex)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }*/
        }

        //step8 -> getting the userinput and checking if it's right
        //Get the user choice and return it as an int
        //And ensuring its a vaild option
        private int GetUserChoice()
        {
            Console.WriteLine("Your Answer (number): ");
            string input = Console.ReadLine();
            int choice = 0;

            /*
             As long as whatever the user entered is a number. 
             So as long as this worked, we're going to keep going 
             with the code after. But if it isn't a number 
             then we're going to try again.
             */

            while (!int.TryParse(input, out choice) || choice < 1 || choice > 4)
            {
                Console.WriteLine("Invalid choice. Please enter a number betwen 1 and 4: ");
                input = Console.ReadLine();
            }
            return choice - 1; //adjust to 0 - indexed array
        }
    }
}
