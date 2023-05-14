using Dice.Models;
using Iot.Device.Mpu6886;
using nanoFramework.AtomMatrix;
using System;
using System.Diagnostics;

namespace Dice.Services {
    public class AccelerometerGyroscopeService {

        private Mpu6886AccelerometerGyroscope Service = AtomMatrix.AccelerometerGyroscope;
        private MatrixScreenService mtx;
        private Accelerometer sensitivity;

        public AccelerometerGyroscopeService(Sensitivy sensitivy, MatrixScreenService _mtx)
        {
            Debug.WriteLine($"Sensitivy was setting on {sensitivy}");
            sensitivity = new Accelerometer(sensitivy);
            Service.Calibrate(100);
            mtx = _mtx;
        }

        public bool CriticalMove()
        {
            CheckTemperature();

            if(Service.GetAccelerometer().X > sensitivity.AccPositiveX || Service.GetAccelerometer().X < sensitivity.AccNegativeX)
            {
                Debug.WriteLine("Throw dice on X axis");
                return true;
            }
            if (Service.GetAccelerometer().Y > sensitivity.AccPositiveY || Service.GetAccelerometer().Y < sensitivity.AccNegativeY)
            {
                Debug.WriteLine("Throw dice on Y axis");
                return true;
            }
            if (Service.GetAccelerometer().Z > sensitivity.AccPositiveZ || Service.GetAccelerometer().Z < sensitivity.AccNegativeZ)
            {
                Debug.WriteLine("Throw dice on Z axis");
                return true;
            }
            
            Debug.WriteLine("No movement");
            return false;
        }

        public bool SaveDice()
        {
            int temperature = (int)Service.GetInternalTemperature().DegreesCelsius;
            if (temperature >= 55)
            {
                mtx.ScreenWarning();
                Service.Sleep();
                Debug.WriteLine($"Device is turn off, temperature is {temperature}");
                return true;
            }
            return false;           
        }

        private void CheckTemperature()
        {
            int temperature = (int)Service.GetInternalTemperature().DegreesCelsius;
            if (temperature >= 50) mtx.ScreenWarning();
            Debug.WriteLine($"Temperature is {temperature}");
        }

    }
}
