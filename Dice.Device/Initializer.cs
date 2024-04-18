using Dice.Device.Services;
using Dice.Device.Utilities;

namespace Dice.Device
{
    internal class Initializer
    {
        private readonly Setup _setup;

        public Initializer()
        {
            _setup = new Setup(); // test
        }

        public void Start()
        {
            bool shake = MotionService.CriticalMove(_setup.Sensitivy); // ok

            if (shake)
            {
                ScreenService.AnimationLoad(_setup.Color); //ok
                ScreenService.AnimationThrowDice(_setup.AnimationTime, _setup.Color); // ok
                ScreenService.ResultThrowDice(_setup.Color); // ok
            }
        }
    }
}
