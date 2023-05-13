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
            MatrixScreenService mtx = new MatrixScreenService(Color.DarkMagenta);
            Random rnd = new Random();

            while (true)
            {
                if (ags.CriticalMove())
                {
                    mtx.AnimationWhenThrowDice();
                    mtx.DrawNumberOnScreen(rnd.Next(7) == 0 ? rnd.Next(7) + 1 : rnd.Next(7));
                }
            }

        }        
    }
}
