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

        }
    }
}