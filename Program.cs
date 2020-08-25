using System;

namespace guessing_game
{
    class Program
    {

        static void Main(string[] args)

        {
            Console.WriteLine("Guess the Secret Number");

            string numberGuess = Console.ReadLine();

            Console.WriteLine($"Your guess was...{numberGuess}");

            string secretNumber = "42";

            while (numberGuess != secretNumber)

                if (numberGuess == secretNumber)
                {
                    Console.WriteLine("Congrats you guessed the right number!");
                }
            else
            {
                Console.WriteLine("Try Again");
            }

        }
    }
}