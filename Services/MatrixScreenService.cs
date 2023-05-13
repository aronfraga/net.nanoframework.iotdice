using Iot.Device.Mpu6886;
using Iot.Device.Ws28xx.Esp32;
using nanoFramework.AtomMatrix;
using nanoFramework.Hardware.Esp32;
using System;
using System.Device.I2c;
using System.Diagnostics;
using System.Drawing;
using System.Threading;


namespace Dice.Services {
    public class MatrixScreenService {

        private Color _color;

        public MatrixScreenService()
        {
            _color = Color.White;
        }

        public MatrixScreenService(Color color)
        {
            _color = color;
        }

        public void DrawNumber()
        {
            void DrawNumberOne()
            {
                AtomMatrix.LedMatrix.Image.SetPixel(2, 2, _color);
                AtomMatrix.LedMatrix.Update();
            }

            void DrawNumberTwo()
            {
                AtomMatrix.LedMatrix.Image.SetPixel(0, 0, _color);
                AtomMatrix.LedMatrix.Image.SetPixel(4, 4, _color);
                AtomMatrix.LedMatrix.Update();
            }

            void DrawNumberThree()
            {
                AtomMatrix.LedMatrix.Image.SetPixel(0, 0, _color);
                AtomMatrix.LedMatrix.Image.SetPixel(2, 2, _color);
                AtomMatrix.LedMatrix.Image.SetPixel(4, 4, _color);
                AtomMatrix.LedMatrix.Update();
            }

            void DrawNumberFour()
            {
                AtomMatrix.LedMatrix.Image.SetPixel(0, 0, _color);
                AtomMatrix.LedMatrix.Image.SetPixel(0, 4, _color);
                AtomMatrix.LedMatrix.Image.SetPixel(4, 0, _color);
                AtomMatrix.LedMatrix.Image.SetPixel(4, 4, _color);
                AtomMatrix.LedMatrix.Update();
            }

            void DrawNumberFive()
            {
                AtomMatrix.LedMatrix.Image.SetPixel(0, 0, _color);
                AtomMatrix.LedMatrix.Image.SetPixel(0, 4, _color);
                AtomMatrix.LedMatrix.Image.SetPixel(2, 2, _color);
                AtomMatrix.LedMatrix.Image.SetPixel(4, 0, _color);
                AtomMatrix.LedMatrix.Image.SetPixel(4, 4, _color);
                AtomMatrix.LedMatrix.Update();
            }

            void DrawNumberSix()
            {
                AtomMatrix.LedMatrix.Image.SetPixel(0, 0, _color);
                AtomMatrix.LedMatrix.Image.SetPixel(0, 4, _color);
                AtomMatrix.LedMatrix.Image.SetPixel(2, 0, _color);
                AtomMatrix.LedMatrix.Image.SetPixel(2, 2, _color);
                AtomMatrix.LedMatrix.Image.SetPixel(2, 4, _color);
                AtomMatrix.LedMatrix.Image.SetPixel(4, 4, _color);
                AtomMatrix.LedMatrix.Update();
            }
        }
        
    }
}
