using Dice.Models;
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

        private Color color;
        
        public MatrixScreenService()
        {
            color = Color.FromHex("#100115");
        }

        public void DrawNumberOnScreen(int number)
        {
            Debug.WriteLine($"Draw number {number} - Color {color}");
            AnimationWhenThrowDice();

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

        public void Animation(AnimationType animation)
        {
            Debug.WriteLine($"Animation: {animation}");
            switch (animation)
            {
                case AnimationType.Loader:
                    DrawAnimationLoader();
                    break;
                case AnimationType.ThrowDice:
                    AnimationWhenThrowDice();
                    break;
                default: 
                    break;
            }
        }

        public void ScreenWarning()
        {
            TemperatureHigh();
            AtomMatrix.LedMatrix.Image.Clear();
            AtomMatrix.LedMatrix.Update();
            Debug.WriteLine("The screen was stopped for high temperature");
        }

        public void ChangeColor(Color _color)
        {
            color = _color;
        }

        private void RunningOnScreen()
        {
            Thread.Sleep(4000);
        }

        private void DrawAnimationLoader() //make a vector 2d
        {
            Thread timeOnScreen = new Thread(new ThreadStart(RunningOnScreen));
            timeOnScreen.Start();
            Debug.WriteLine($"Thread on screen is alive: {timeOnScreen.IsAlive}");

            while (timeOnScreen.IsAlive)
            {
                LoadCircleStateOne();
                LoadCircleStateTwo();
                LoadCircleStateThree();
                LoadCircleStateFour();
                LoadCircleStateFive();
                LoadCircleStateSix();
                LoadCircleStateSeven();
                LoadCircleStateEight();
            }
            Debug.WriteLine($"Thread on screen is alive: {timeOnScreen.IsAlive}");
            HappyEmoticon();
        }

        private void AnimationWhenThrowDice()
        {
            Thread timeOnScreen = new Thread(new ThreadStart(RunningOnScreen));
            timeOnScreen.Start();
            Debug.WriteLine($"Thread on screen is alive: {timeOnScreen.IsAlive}");

            while (timeOnScreen.IsAlive)
            {
                DiceNumberOne();
                DiceNumberTwo();
                DiceNumberThree();
                DiceNumberFour();
                DiceNumberFive();
                DiceNumberSix();
            }
            Debug.WriteLine($"Thread on screen is alive: {timeOnScreen.IsAlive}");
        }

        private void DiceNumberOne() //Make a design pattern here
        {
            AtomMatrix.LedMatrix.Image.Clear();
            AtomMatrix.LedMatrix.Image.SetPixel(2, 2, color);
            AtomMatrix.LedMatrix.Update();
            Debug.WriteLine("Screen Updated");
        }

        private void DiceNumberTwo()
        {
            AtomMatrix.LedMatrix.Image.Clear();
            AtomMatrix.LedMatrix.Image.SetPixel(0, 0, color);
            AtomMatrix.LedMatrix.Image.SetPixel(4, 4, color);
            AtomMatrix.LedMatrix.Update();
            Debug.WriteLine("Screen Updated");
        }

        private void DiceNumberThree()
        {
            AtomMatrix.LedMatrix.Image.Clear();
            AtomMatrix.LedMatrix.Image.SetPixel(0, 0, color);
            AtomMatrix.LedMatrix.Image.SetPixel(2, 2, color);
            AtomMatrix.LedMatrix.Image.SetPixel(4, 4, color);
            AtomMatrix.LedMatrix.Update();
            Debug.WriteLine("Screen Updated");
        }

        private void DiceNumberFour()
        {
            AtomMatrix.LedMatrix.Image.Clear();
            AtomMatrix.LedMatrix.Image.SetPixel(0, 0, color);
            AtomMatrix.LedMatrix.Image.SetPixel(0, 4, color);
            AtomMatrix.LedMatrix.Image.SetPixel(4, 0, color);
            AtomMatrix.LedMatrix.Image.SetPixel(4, 4, color);
            AtomMatrix.LedMatrix.Update();
            Debug.WriteLine("Screen Updated");
        }

        private void DiceNumberFive()
        {
            AtomMatrix.LedMatrix.Image.Clear();
            AtomMatrix.LedMatrix.Image.SetPixel(0, 0, color);
            AtomMatrix.LedMatrix.Image.SetPixel(0, 4, color);
            AtomMatrix.LedMatrix.Image.SetPixel(2, 2, color);
            AtomMatrix.LedMatrix.Image.SetPixel(4, 0, color);
            AtomMatrix.LedMatrix.Image.SetPixel(4, 4, color);
            AtomMatrix.LedMatrix.Update();
            Debug.WriteLine("Screen Updated");
        }

        private void DiceNumberSix()
        {
            AtomMatrix.LedMatrix.Image.Clear();
            AtomMatrix.LedMatrix.Image.SetPixel(0, 0, color);
            AtomMatrix.LedMatrix.Image.SetPixel(0, 4, color);
            AtomMatrix.LedMatrix.Image.SetPixel(0, 2, color);
            AtomMatrix.LedMatrix.Image.SetPixel(4, 2, color);
            AtomMatrix.LedMatrix.Image.SetPixel(4, 0, color);
            AtomMatrix.LedMatrix.Image.SetPixel(4, 4, color);
            AtomMatrix.LedMatrix.Update();
            Debug.WriteLine("Screen Updated");
        }

        private void LoadCircleStateOne()
        {
            AtomMatrix.LedMatrix.Image.Clear();
            AtomMatrix.LedMatrix.Image.SetPixel(1, 1, color);
            AtomMatrix.LedMatrix.Image.SetPixel(1, 2, color);
            AtomMatrix.LedMatrix.Image.SetPixel(1, 3, color);
            AtomMatrix.LedMatrix.Image.SetPixel(2, 1, color);
            AtomMatrix.LedMatrix.Image.SetPixel(2, 3, color);
            AtomMatrix.LedMatrix.Image.SetPixel(3, 1, color);
            AtomMatrix.LedMatrix.Image.SetPixel(3, 3, color);
            AtomMatrix.LedMatrix.Update();
            Debug.WriteLine("Screen Updated");
        }

        private void LoadCircleStateTwo()
        {
            AtomMatrix.LedMatrix.Image.Clear();
            AtomMatrix.LedMatrix.Image.SetPixel(1, 1, color);
            AtomMatrix.LedMatrix.Image.SetPixel(1, 2, color);
            AtomMatrix.LedMatrix.Image.SetPixel(1, 3, color);
            AtomMatrix.LedMatrix.Image.SetPixel(2, 1, color);
            AtomMatrix.LedMatrix.Image.SetPixel(2, 3, color);
            AtomMatrix.LedMatrix.Image.SetPixel(3, 1, color);
            AtomMatrix.LedMatrix.Image.SetPixel(3, 2, color);
            AtomMatrix.LedMatrix.Update();
            Debug.WriteLine("Screen Updated");
        }

        private void LoadCircleStateThree()
        {
            AtomMatrix.LedMatrix.Image.Clear();
            AtomMatrix.LedMatrix.Image.SetPixel(1, 1, color);
            AtomMatrix.LedMatrix.Image.SetPixel(1, 2, color);
            AtomMatrix.LedMatrix.Image.SetPixel(1, 3, color);
            AtomMatrix.LedMatrix.Image.SetPixel(2, 1, color);
            AtomMatrix.LedMatrix.Image.SetPixel(3, 1, color);
            AtomMatrix.LedMatrix.Image.SetPixel(3, 2, color);
            AtomMatrix.LedMatrix.Image.SetPixel(3, 3, color);
            AtomMatrix.LedMatrix.Update();
            Debug.WriteLine("Screen Updated");
        }

        private void LoadCircleStateFour()
        {
            AtomMatrix.LedMatrix.Image.Clear();
            AtomMatrix.LedMatrix.Image.SetPixel(1, 1, color);
            AtomMatrix.LedMatrix.Image.SetPixel(1, 2, color);
            AtomMatrix.LedMatrix.Image.SetPixel(2, 1, color);
            AtomMatrix.LedMatrix.Image.SetPixel(2, 3, color);
            AtomMatrix.LedMatrix.Image.SetPixel(3, 1, color);
            AtomMatrix.LedMatrix.Image.SetPixel(3, 2, color);
            AtomMatrix.LedMatrix.Image.SetPixel(3, 3, color);
            AtomMatrix.LedMatrix.Update();
            Debug.WriteLine("Screen Updated");
        }

        private void LoadCircleStateFive()
        {
            AtomMatrix.LedMatrix.Image.Clear();
            AtomMatrix.LedMatrix.Image.SetPixel(1, 1, color);
            AtomMatrix.LedMatrix.Image.SetPixel(1, 3, color);
            AtomMatrix.LedMatrix.Image.SetPixel(2, 1, color);
            AtomMatrix.LedMatrix.Image.SetPixel(2, 3, color);
            AtomMatrix.LedMatrix.Image.SetPixel(3, 1, color);
            AtomMatrix.LedMatrix.Image.SetPixel(3, 2, color);
            AtomMatrix.LedMatrix.Image.SetPixel(3, 3, color);
            AtomMatrix.LedMatrix.Update();
            Debug.WriteLine("Screen Updated");
        }

        private void LoadCircleStateSix()
        {
            AtomMatrix.LedMatrix.Image.Clear();
            AtomMatrix.LedMatrix.Image.SetPixel(1, 2, color);
            AtomMatrix.LedMatrix.Image.SetPixel(1, 3, color);
            AtomMatrix.LedMatrix.Image.SetPixel(2, 1, color);
            AtomMatrix.LedMatrix.Image.SetPixel(2, 3, color);
            AtomMatrix.LedMatrix.Image.SetPixel(3, 1, color);
            AtomMatrix.LedMatrix.Image.SetPixel(3, 2, color);
            AtomMatrix.LedMatrix.Image.SetPixel(3, 3, color);
            AtomMatrix.LedMatrix.Update();
            Debug.WriteLine("Screen Updated");
        }

        private void LoadCircleStateSeven()
        {
            AtomMatrix.LedMatrix.Image.Clear();
            AtomMatrix.LedMatrix.Image.SetPixel(1, 1, color);
            AtomMatrix.LedMatrix.Image.SetPixel(1, 2, color);
            AtomMatrix.LedMatrix.Image.SetPixel(1, 3, color);
            AtomMatrix.LedMatrix.Image.SetPixel(2, 3, color);
            AtomMatrix.LedMatrix.Image.SetPixel(3, 1, color);
            AtomMatrix.LedMatrix.Image.SetPixel(3, 2, color);
            AtomMatrix.LedMatrix.Image.SetPixel(3, 3, color);
            AtomMatrix.LedMatrix.Update();
            Debug.WriteLine("Screen Updated");
        }

        private void LoadCircleStateEight()
        {
            AtomMatrix.LedMatrix.Image.Clear();
            AtomMatrix.LedMatrix.Image.SetPixel(1, 1, color);
            AtomMatrix.LedMatrix.Image.SetPixel(1, 2, color);
            AtomMatrix.LedMatrix.Image.SetPixel(1, 3, color);
            AtomMatrix.LedMatrix.Image.SetPixel(2, 1, color);
            AtomMatrix.LedMatrix.Image.SetPixel(2, 3, color);
            AtomMatrix.LedMatrix.Image.SetPixel(3, 2, color);
            AtomMatrix.LedMatrix.Image.SetPixel(3, 3, color);
            AtomMatrix.LedMatrix.Update();
            Debug.WriteLine("Screen Updated");
        }

        private void HappyEmoticon()
        {
            AtomMatrix.LedMatrix.Image.Clear();
            AtomMatrix.LedMatrix.Image.SetPixel(0, 3, color);
            AtomMatrix.LedMatrix.Image.SetPixel(1, 0, color);
            AtomMatrix.LedMatrix.Image.SetPixel(1, 1, color);
            AtomMatrix.LedMatrix.Image.SetPixel(1, 4, color);
            AtomMatrix.LedMatrix.Image.SetPixel(2, 4, color);
            AtomMatrix.LedMatrix.Image.SetPixel(3, 0, color);
            AtomMatrix.LedMatrix.Image.SetPixel(3, 1, color);
            AtomMatrix.LedMatrix.Image.SetPixel(3, 4, color);
            AtomMatrix.LedMatrix.Image.SetPixel(4, 3, color);
            AtomMatrix.LedMatrix.Update();
            Debug.WriteLine("Screen Updated");
        }

        private void TemperatureHigh()
        {
            AtomMatrix.LedMatrix.Image.Clear();
            AtomMatrix.LedMatrix.Image.SetPixel(2, 0, Color.Red);
            AtomMatrix.LedMatrix.Image.SetPixel(2, 1, Color.Red);
            AtomMatrix.LedMatrix.Image.SetPixel(2, 2, Color.Red);
            AtomMatrix.LedMatrix.Image.SetPixel(2, 4, Color.Red);
            AtomMatrix.LedMatrix.Update();
            Debug.WriteLine("Screen Updated");
        }

    }
}
