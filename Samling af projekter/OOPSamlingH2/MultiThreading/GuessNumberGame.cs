using System;
using System.Collections.Generic;
using System.Text;

namespace MultiThreading
{
    class GuessNumberGame
    {
        public static int GuessNumber()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 11);

            return randomNumber;
        }
    }
}
