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

        public void DrawNumberOnScreen(int number)
        {
            Debug.WriteLine($"Draw number {number} - Color {_color}");
            switch (number)
            {
                case 1:
                    DiceNumberOne();
                    break;
                case 2:
                    DiceNumberTwo();
                    break;
                case 3:
                    DiceNumberThree();
                    break;
                case 4:
                    DiceNumberFour();
                    break;
                case 5:
                    DiceNumberFive();
                    break;
                case 6:
                    DiceNumberSix();
                    break;
                default:
                    break;
            }
        }

        public void AnimationWhenThrowDice()
        {//task with thread sync
            for (int time = 0; time < 2; time++)
            {
                for (int cicle = 0; cicle <= 6; cicle++)
                {
                    DrawNumberOnScreen(cicle);
                    Thread.Sleep(100);
                }
            }
        }

        private void DiceNumberOne()
        {
            AtomMatrix.LedMatrix.Image.Clear();
            AtomMatrix.LedMatrix.Image.SetPixel(2, 2, _color);
            AtomMatrix.LedMatrix.Update();
            Debug.WriteLine("Screen Updated");
        }

        private void DiceNumberTwo()
        {
            AtomMatrix.LedMatrix.Image.Clear();
            AtomMatrix.LedMatrix.Image.SetPixel(0, 0, _color);
            AtomMatrix.LedMatrix.Image.SetPixel(4, 4, _color);
            AtomMatrix.LedMatrix.Update();
            Debug.WriteLine("Screen Updated");
        }

        private void DiceNumberThree()
        {
            AtomMatrix.LedMatrix.Image.Clear();
            AtomMatrix.LedMatrix.Image.SetPixel(0, 0, _color);
            AtomMatrix.LedMatrix.Image.SetPixel(2, 2, _color);
            AtomMatrix.LedMatrix.Image.SetPixel(4, 4, _color);
            AtomMatrix.LedMatrix.Update();
            Debug.WriteLine("Screen Updated");
        }

        private void DiceNumberFour()
        {
            AtomMatrix.LedMatrix.Image.Clear();
            AtomMatrix.LedMatrix.Image.SetPixel(0, 0, _color);
            AtomMatrix.LedMatrix.Image.SetPixel(0, 4, _color);
            AtomMatrix.LedMatrix.Image.SetPixel(4, 0, _color);
            AtomMatrix.LedMatrix.Image.SetPixel(4, 4, _color);
            AtomMatrix.LedMatrix.Update();
            Debug.WriteLine("Screen Updated");
        }

        private void DiceNumberFive()
        {
            AtomMatrix.LedMatrix.Image.Clear();
            AtomMatrix.LedMatrix.Image.SetPixel(0, 0, _color);
            AtomMatrix.LedMatrix.Image.SetPixel(0, 4, _color);
            AtomMatrix.LedMatrix.Image.SetPixel(2, 2, _color);
            AtomMatrix.LedMatrix.Image.SetPixel(4, 0, _color);
            AtomMatrix.LedMatrix.Image.SetPixel(4, 4, _color);
            AtomMatrix.LedMatrix.Update();
            Debug.WriteLine("Screen Updated");
        }

        private void DiceNumberSix()
        {
            AtomMatrix.LedMatrix.Image.Clear();
            AtomMatrix.LedMatrix.Image.SetPixel(0, 0, _color);
            AtomMatrix.LedMatrix.Image.SetPixel(0, 4, _color);
            AtomMatrix.LedMatrix.Image.SetPixel(2, 0, _color);
            AtomMatrix.LedMatrix.Image.SetPixel(2, 4, _color);
            AtomMatrix.LedMatrix.Image.SetPixel(4, 0, _color);
            AtomMatrix.LedMatrix.Image.SetPixel(4, 4, _color);
            AtomMatrix.LedMatrix.Update();
            Debug.WriteLine("Screen Updated");
        }

    }
}
