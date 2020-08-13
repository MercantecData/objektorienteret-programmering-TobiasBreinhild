using System;
using MultiThreading;
using System.Threading.Tasks;

namespace MultiThreading
{
    class MultiThreadingProgram
    {
        static void Main(string[] args)
        {
            bool stillWrong = true;

            Timer.timerThingy(1, 11, "Time Left: ");

            int numberToGuess = GuessNumberGame.GuessNumber();

            while (stillWrong == true)
            {
                Console.Write("Guess: ");
                string input = Console.ReadLine();

                if (Int16.Parse(input) == numberToGuess)
                {
                    stillWrong = false;
                    Environment.Exit(0);

                }
            }
        }
    }
}
