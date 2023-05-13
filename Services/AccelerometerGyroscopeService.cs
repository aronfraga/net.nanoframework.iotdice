using Dice.Models;
using Iot.Device.Mpu6886;
using nanoFramework.AtomMatrix;
using System;
using System.Diagnostics;

namespace Dice.Services {
    public class AccelerometerGyroscopeService {

        private Mpu6886AccelerometerGyroscope Service = AtomMatrix.AccelerometerGyroscope;
        private Sensitivity sensitivity;

        public AccelerometerGyroscopeService()
        {
            sensitivity = new Sensitivity(1);
            Service.Calibrate(100);
        }

        public bool CriticalMove()
        {
            if(Service.GetAccelerometer().X > sensitivity.AccPositiveX || Service.GetAccelerometer().X < sensitivity.AccNegativeX)
            {
                Debug.WriteLine("Throw dice");
                return true;
            }
            Debug.WriteLine("No movement");
            return false;
        }

    }
}
