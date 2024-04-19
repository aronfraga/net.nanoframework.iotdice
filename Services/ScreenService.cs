using Dice.Device.Abstractions;
using Dice.Device.Utilities;
using System.Drawing;
using System;

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

            for (int i = 0; i < (int)AnimationTime.ThreeSeconds; i++)
            {
                screenService.PlayAnimation();
            }
            
            DrawOnScreen(Pattern.HappyEmoticon, color);
        }

        public static void AnimationThrowDice(AnimationTime AnimationTime, Color color)
        {
            ScreenService screenService = new ScreenService(Pattern.ThrowAnimation, color);
            DateTime endTime = DateTime.UtcNow.AddSeconds((int)AnimationTime);

            do
            {
                screenService.PlayAnimation();
            } while (DateTime.UtcNow < endTime);
        }

        public static void ResultThrowDice(Color color)
        {
            Pattern patternNumber = RandomNumber.GenerateRandomNumber();
            ScreenService screenService = new ScreenService(patternNumber, color);
            screenService.DrawScreen();
        }

        public static void DrawOnScreen(Pattern pattern, Color color)
        {
            ScreenService screenService = new ScreenService(pattern, color);
            screenService.DrawScreen();
        }
    }
}
