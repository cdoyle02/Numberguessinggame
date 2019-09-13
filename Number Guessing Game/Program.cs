using System;

namespace Number_Guessing_Game
{
    class Program
    {
        static int GetIntegerFromUser(string question)
        {
            int integerFromUser;
            bool success;
            do
            {
                Console.WriteLine(question);
                string userResponse = Console.ReadLine();
                success = int.TryParse(userResponse, out integerFromUser);
            } while (success == false);

            return integerFromUser;

        }
        

        static void Main(string[] args)
        {
            Console.WriteLine("Let's play a guessing game! The higher your score, the worst you did(you FOOL)!");

            Console.WriteLine("");

            int max = GetIntegerFromUser("First, give us a max for our range of numbers, so you can guess wrong.");

            Random rnd = new Random();

            int secretNumber = rnd.Next(1, max + 1);

            int guess = GetIntegerFromUser("Take a guess, fool.");

            

            if (guess == secretNumber)
            {
                Console.WriteLine($"Well, {guess} is it. On your first try? Maybe I am the fool.");
            }
            else
            {
                int score = 1;
                do
                {
                    if (guess > secretNumber)
                    {
                        guess = GetIntegerFromUser("Oops...too high, idiot.Try again!");
                    }
                    if (guess < secretNumber)
                    {
                        guess = GetIntegerFromUser("Oops...too low, idiot. Try again!");
                    }
                    score++;
                } while (guess != secretNumber);
                
                Console.WriteLine($"Well, {guess} is it. Only took you {score} guesses, you really are the fool I thought!");
            }

        }



    }
}

