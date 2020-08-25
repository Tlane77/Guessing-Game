using System;

namespace guessing_game
{
    class Program
    {

        static void Main(string[] args)

        {

            string secretNumber = "42";

            int numberAttempts = 0;

            while (numberAttempts < 4)
            {
                Console.WriteLine("Guess the Secret Number");

                string numberGuess = Console.ReadLine();

                if (numberGuess == secretNumber)
                {
                    Console.WriteLine("Congrats you guessed the right number!");
                }
                else
                {
                    numberAttempts++;
                    Console.WriteLine("Try Again");
                }

            }
        }
    }
}