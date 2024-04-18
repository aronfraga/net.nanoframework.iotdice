using Dice.Device.Utilities;
using nanoFramework.AtomMatrix;
using System.Drawing;

namespace Dice.Device.Abstractions
{
    internal abstract class Screen
    {
        private ScreenPattern screenPattern = new ScreenPattern();
        private Pattern _pattern;
        private Color _color;
        private int lastSequence = 5;

        protected Screen(Pattern pattern, Color color)
        {
            _pattern = pattern;
            _color = color;
        }

        public void DrawScreen()
        {
            short[] matrix = screenPattern.GetMatrixPattern(_pattern);
            AtomMatrix.LedMatrix.Image.Clear();

            for (int i = 0; i < matrix.Length; i += 2)
            {
                int xCoordinate = matrix[i];
                int yCoordinate = matrix[i + 1];

                AtomMatrix.LedMatrix.Image.SetPixel(xCoordinate, yCoordinate, _color);
            }

            AtomMatrix.LedMatrix.Update();
        }

        public void PlayAnimation()
        {
            short[] matrix = screenPattern.GetMatrixPattern(_pattern);
            AtomMatrix.LedMatrix.Image.Clear();

            for (int i = 0; i < matrix.Length; i += 2)
            {
                int xCoordinate = matrix[i];
                int yCoordinate = matrix[i + 1];

                if (xCoordinate != lastSequence && yCoordinate != lastSequence)
                {
                    AtomMatrix.LedMatrix.Image.SetPixel(xCoordinate, yCoordinate, _color);
                }
                else
                {
                    RefreshScreen();
                }
            }
        }

        private void RefreshScreen()
        {
            AtomMatrix.LedMatrix.Update();
            AtomMatrix.LedMatrix.Image.Clear();
        }
    }
}
