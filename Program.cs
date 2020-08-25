using System;

namespace guessing_game
{
    class Program
    {

        static void Main(string[] args)

        {

            int secretNumber = new Random().Next(1, 101);

            int numberOfAttempts = 0;

            Console.WriteLine($"Can you guess the secret number? >>");

            while (numberOfAttempts < 4)
            {
                Console.WriteLine($"Try to Guess the secret number? You have guessed {4 - numberOfAttempts} guesses left.");

                int numberGuess = Int32.Parse(Console.ReadLine());

                if (numberGuess == secretNumber)
                {
                    Console.WriteLine("Congrats you guessed the right number!");
                    numberOfAttempts = 4;
                }
                else
                {
                    numberOfAttempts++;
                    Console.WriteLine("Try Again!");
                }

            }
        }
    }
}