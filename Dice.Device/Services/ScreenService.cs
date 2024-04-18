using Dice.Device.Abstractions;
using Dice.Device.Utilities;
using System;
using System.Drawing;

namespace Dice.Device.Services
{
    internal sealed class ScreenService : Screen
    {
        private ScreenService(Pattern pattern, Color color) : base(pattern, color)
        {
        }

        public static void AnimationLoad(Color color)
        {
            ScreenService screenService = new ScreenService(Pattern.LoadAnimation, color);
            screenService.SetScreen();
        }

        public static void AnimationThrowDice(AnimationTime AnimationTime, Color color)
        {
            ScreenService screenService = new ScreenService(Pattern.ThrowAnimation, color);
            screenService.SetScreen();

            DateTime endTime = DateTime.UtcNow.AddSeconds((int)AnimationTime);

            while (DateTime.UtcNow < endTime)
            {
                screenService.SetScreen();
                //Thread.Sleep(100);
            }
        }

        public static void ResultThrowDice(int number, Color color)
        {
            ScreenService screenService = new ScreenService((Pattern)number, color);
            screenService.SetScreen();
        }
    }
}
