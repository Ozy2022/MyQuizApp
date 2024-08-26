MyQuizApp is a simple console-based quiz application developed using Object-Oriented Programming (OOP) principles in C#. The application is designed to demonstrate the core concepts of OOP such as encapsulation, inheritance, and polymorphism, while providing a fun and interactive quiz experience.

Features
Multiple Choice Questions: The app includes a set of predefined multiple-choice questions, each with four possible answers.
Question Class: A dedicated Question class encapsulates the question text, possible answers, and the correct answer index.
Quiz Class: The Quiz class manages the flow of the quiz, including displaying questions, collecting user responses, and determining the score.
User Interaction: The app interacts with the user via the console, allowing them to answer questions and receive feedback instantly.
How It Works
Question Creation: The application initializes an array of Question objects, each representing a quiz question with associated answers.
Quiz Initialization: These questions are then passed to a Quiz object, which handles the quiz execution.
Quiz Execution: The StartQuiz method of the Quiz class presents each question to the user, collects their answer, and provides feedback based on their selection.
End of Quiz: After all questions are answered, the user's score is displayed, showing their performance in the quiz.


Future Improvements
Dynamic Question Loading: Implementing a feature to load questions from external sources like a file or database.
User Score Tracking: Adding a feature to track and store user scores for future reference.
Timed Quiz: Introducing a timer to make the quiz more challenging.
Getting Started
Clone the repository and run the MyQuizApp solution in Visual Studio or your preferred C# development environment. The quiz runs in the console, providing an interactive experience.


Simple OutPut


![simple output](https://github.com/user-attachments/assets/a86979f7-141b-4b52-b3f7-5829211e59ea)
