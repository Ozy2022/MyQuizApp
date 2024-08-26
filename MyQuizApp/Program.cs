namespace MyQuizApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //step 7.5 to test -> create question and answer 
            //so we are passing 3 args that we have in
            //the Q class to this new object
            Question[] questions = new Question[]
            {
                new Question("What is the capital of Germany?",
                new string[] {"Paris", "Berlin", "London", "Madrid"},
                1
                ),
                new Question("What is 2+2",
                new string[] {"4", "3", "5", "6"},
                0
                ),
                new Question("Who wrote 'Hamblet' book?",
                new string[] {"Shakespeare", "Dickens", "Goethe", "Austen"},
                3
                ),

            };


            Quiz myQuiz = new Quiz(questions);
            myQuiz.StartQuiz();

            Console.ReadLine();
        }
    }
}
