using Dice.Services;
using Iot.Device.Mpu6886;
using Iot.Device.Ws28xx.Esp32;
using nanoFramework.AtomMatrix;
using nanoFramework.Hardware.Esp32;
using System;
using System.Device.I2c;
using System.Diagnostics;
using System.Drawing;
using System.Threading;

namespace Dice {
    public class Program {
        public static void Main()
        {
            AccelerometerGyroscopeService ags = new AccelerometerGyroscopeService();
            while (true)
            {
                if (ags.CriticalMove())
                {
                    Debug.WriteLine("True");
                }
                Debug.WriteLine("False");
            }
        }        
    }
}
