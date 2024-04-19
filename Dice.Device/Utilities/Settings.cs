using System.Drawing;

namespace Dice.Device.Utilities
{
    internal class Settings
    {
        public Color Color { get; private set; }
        public Sensitivy Sensitivy { get; private set; }
        public AnimationTime AnimationTime { get; private set; }
        public double MaxTemperature { get; private set; }
        public double WarningTemperature { get; private set; }

        public Settings() 
        {
            Color = Color.FromHex("#100115");
            Sensitivy = Sensitivy.Medium;
            AnimationTime = AnimationTime.TwoSeconds;
            MaxTemperature = 55.00;
            WarningTemperature = 50.00;
        }

        public Settings(Color color, Sensitivy sensitivy, AnimationTime animationTime, double maxTemperature, double warningTemperature)
        {
            Color = color;
            Sensitivy = sensitivy;
            AnimationTime = animationTime;
            MaxTemperature = maxTemperature;
            WarningTemperature = warningTemperature;
        }
    }
}
