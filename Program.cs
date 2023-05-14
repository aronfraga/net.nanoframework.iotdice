using Dice.Models;
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
            
            MatrixScreenService mtx = new MatrixScreenService();
            AccelerometerGyroscopeService ags = new AccelerometerGyroscopeService(Sensitivy.Medium, mtx);
            Random rnd = new Random();

            mtx.Animation(AnimationType.Loader);
            
            while (true)
            {
                if (ags.CriticalMove())
                {
                    mtx.DrawNumberOnScreen(rnd.Next(7) == 0 ? rnd.Next(7) + 1 : rnd.Next(7));
                }
                if(ags.SaveDice())
                {
                    break;
                }
            }

        }
    }
}
