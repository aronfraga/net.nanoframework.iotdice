using Dice.Device.Utilities;
using nanoFramework.AtomMatrix;
using System.Diagnostics;
using System.Drawing;

namespace Dice.Device.Abstractions
{
    internal abstract class Screen
    {
        private ScreenPattern screenPattern = new ScreenPattern();
        private Pattern _pattern;
        private Color _color;

        protected Screen(Pattern pattern, Color color)
        {
            _pattern = pattern;
            _color = color;
        }

        public void SetScreen()
        {
            short[] matrix = screenPattern.GetMatrixPattern(_pattern);
            AtomMatrix.LedMatrix.Image.Clear();

            for (int i = 0; i < matrix.Length; i += 2)
            {
                AtomMatrix.LedMatrix.Image.SetPixel(matrix[i], matrix[i + 1], _color);
            }

            AtomMatrix.LedMatrix.Update();
            Debug.WriteLine("Screen Updated");
        }
    }
}
