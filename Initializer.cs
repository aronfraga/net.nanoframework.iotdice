using Dice.Device.Abstractions;
using Dice.Device.Services;
using Dice.Device.Utilities;
using System;
using System.Drawing;

namespace Dice.Device
{
    internal class Initializer : Miscellaneous
    {
        private bool firstStart = true;

        public Initializer(Settings settings) : base(settings)
        {
        }

        public void Start()
        {
            try
            {
                SystemWarning();

                if (canContinue)
                {
                    LoaderAnimation();
                    MovementsAndScreen();
                }   
            }
            catch (Exception ex)
            {
                Debugger(ex);
            }
        }

        private void LoaderAnimation()
        {
            if (firstStart)
            {
                firstStart = false;
                ScreenService.AnimationLoad(_settings.Color);
            }   
        }

        private void MovementsAndScreen()
        {
            bool shake = MotionService.CriticalMove(_settings.Sensitivy); 

            if (shake)
            {     
                ScreenService.AnimationThrowDice(_settings.AnimationTime, _settings.Color); 
                ScreenService.ResultThrowDice(_settings.Color); 
            }
        }

        private void SystemWarning()
        {
            if (showWarning)
            {
                ScreenService.DrawOnScreen(Pattern.Warning, Color.Red);
            }
        }
    }
}
