using System;

namespace guessing_game
{
    class Program
    {

        static void Main(string[] args)

        {

            string secretNumber = "42";

            int numberOfAttempts = 0;

            while (numberOfAttempts < 4)
            {
                Console.WriteLine("Try to Guess the secret number? You have guessed {$numberOfAttempts} times.");

                string numberGuess = Console.ReadLine();

                if (numberGuess == secretNumber)
                {
                    Console.WriteLine("Congrats you guessed the right number!");
                    numberOfAttempts = 4;
                }
                else
                {
                    numberOfAttempts++;
                    Console.WriteLine("Try Again");
                }

            }
        }
    }
}