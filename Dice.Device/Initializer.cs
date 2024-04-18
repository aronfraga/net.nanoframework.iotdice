using Dice.Device.Services;
using Dice.Device.Utilities;
using System;
using System.Diagnostics;


namespace Dice.Device
{
    internal class Initializer
    {
        private bool keepRunning = false;
        private readonly Random randomNumber = new Random();
        private readonly Setup _setup;

        public Initializer()
        {
            _setup = new Setup(); // test
        }

        public void Stop()
        {
            keepRunning = false;
        }

        public void Start()
        {
            bool shake = MotionService.CriticalMove(_setup.Sensitivy); // ok

            if (shake)
            {
                //ScreenService.AnimationThrowDice(_setup.AnimationTime, _setup.Color);
                ScreenService.ResultThrowDice(GenerateRandomNumber(), _setup.Color);
            }
        }

        private int GenerateRandomNumber()
        {
            int number;

            if (randomNumber.Next(7) == 0)
            {
                number = randomNumber.Next(7) + 1;
            }
            else
            {
                number = randomNumber.Next(7);
            }

            return number;
        }
    }
}
