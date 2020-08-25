using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guessing_game
{
    class Program
    {

        static void Main(string[] args)

        {

            //variable that holds the secretNumber

            int secretNumber = new Random().Next(1, 101);
            //Holds the number of Attempts
            int numberOfAttempts = 0;
            int attemptsAvailable = 0;
            bool difficultySet = false;
            bool isCheater = false;

            while (!difficultySet)
            {
                Console.WriteLine("Select difficulty easy,medium, hard.");
                string difficulty = Console.ReadLine();
                {
                    if (difficulty == "easy")
                    {
                        attemptsAvailable = 8;
                        difficultySet = true;

                    }
                    else if (difficulty == "medium")
                    {
                        attemptsAvailable = 6;
                        difficultySet = true;
                    }
                    else if (difficulty == "hard")
                    {
                        attemptsAvailable = 4;
                        difficultySet = true;
                    }
                    else if (difficulty == "Cheater")
                    {
                        attemptsAvailable = 4;
                        difficultySet = true;
                        isCheater = true;
                    }
                }
            }
            Console.WriteLine($"Can you guess the secret number? >>");
            while (numberOfAttempts < attemptsAvailable)
            {
                Console.WriteLine($"Your Attempts Remaining {attemptsAvailable - numberOfAttempts}");

                int numberGuess = Int32.Parse(Console.ReadLine());

                if (numberGuess == secretNumber)
                {
                    Console.WriteLine("Congrats you guessed the right number!");
                    break;
                }

                else if (numberGuess > secretNumber)

                {
                    Console.WriteLine("Your guess was too high");
                    if (!isCheater) numberOfAttempts++;
                }
                else if (numberGuess < secretNumber)
                {
                    Console.WriteLine("Your guess was too low");
                    if (!isCheater) numberOfAttempts++;
                }
                else
                {
                    if (!isCheater) numberOfAttempts++;
                    Console.WriteLine("Try Again!");
                }

            }

        }
    }
}