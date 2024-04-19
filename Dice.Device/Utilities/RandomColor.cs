using System;
using System.Drawing;

namespace Dice.Device.Utilities
{
    internal sealed class RandomColor
    {
        private RandomColor()
        {
        }

        public static Color GenerateRandomColor()
        {
            Random randomNumber = new Random();

            int red = randomNumber.Next(256);
            int green = randomNumber.Next(256);
            int blue = randomNumber.Next(256);

            return Color.FromArgb(red, green, blue);
        }
    }
}
