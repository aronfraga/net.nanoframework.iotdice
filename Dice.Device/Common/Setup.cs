using System.Drawing;

namespace Dice.Device.Common
{
    internal sealed class Setup
    {
        public Color Color { get; set; }
        public Sensitivy Sensitivy { get; set; }
        public AnimationTime AnimationTime { get; set; }

        public Setup()
        {
            Color = Color.FromHex("#100115");
            Sensitivy = Sensitivy.Medium;
            AnimationTime = AnimationTime.TwoSeconds;
        }

    }
}
