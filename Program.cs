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

            Console.WriteLine($"Can you guess the secret number? >>");
            while (!difficultySet)
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
            }

            while (numberOfAttempts < attemptsAvailable)
            {
                Console.WriteLine($"Your Attempts Remaining {4 - numberOfAttempts}");

                int numberGuess = Int32.Parse(Console.ReadLine());

                if (numberGuess == secretNumber)
                {
                    Console.WriteLine("Congrats you guessed the right number!");
                    break;
                }

                else if (numberGuess > secretNumber)

                {
                    Console.WriteLine("Your guess was too high");
                    numberOfAttempts++;
                }
                else if (numberGuess < secretNumber)
                {
                    Console.WriteLine("Your guess was too low");
                    numberOfAttempts++;
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