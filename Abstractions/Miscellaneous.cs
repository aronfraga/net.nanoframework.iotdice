using Dice.Device.Utilities;
using nanoFramework.AtomMatrix;
using System;
using System.Diagnostics;

namespace Dice.Device.Abstractions
{
    internal abstract class Miscellaneous
    {
        protected bool canContinue = true;
        protected bool showWarning = false;
        protected readonly Settings _settings;

        protected Miscellaneous(Settings settings) 
        { 
            _settings = settings;
        }

        public void CheckHardwareTemperature()
        {
            double temperatureNow = AtomMatrix.AccelerometerGyroscope.GetInternalTemperature().DegreesCelsius;

            if (temperatureNow >= _settings.MaxTemperature)
            {
                canContinue = false;
            }

            if (temperatureNow >= _settings.WarningTemperature)
            {
                showWarning = true;
            }
        }

        public void Debugger(Exception ex)
        {
            Debug.WriteLine($"[Critical] - [Exception] - [Message]: [{ex.Message}]");
            Debug.WriteLine($"[Critical] - [Exception] - [StackTrace]: [{ex.StackTrace}]");
            Debug.WriteLine($"[Critical] - [Exception] - [InnerException]: [{ex.InnerException}]");
        }

        public void Debugger()
        {
            Debug.WriteLine($"[Result] - [Method] - []");
        }
    }
}
