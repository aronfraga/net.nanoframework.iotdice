using System;
using System.Diagnostics;

namespace Dice.Device.Utilities
{
    internal sealed class RandomNumber
    {
        private RandomNumber() 
        {       
        }

        public static Pattern GenerateRandomNumber()
        {
            Random randomNumber = new Random();

            int number = randomNumber.Next(7);

            if (number == 0)
            {
                number = randomNumber.Next(7) + 1;
            }

            Debug.WriteLine($"[OUT] - [RandomNumber] - [{number}]");
            return (Pattern)number;
        }
    }
}
