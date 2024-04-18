using nanoFramework.AtomMatrix;

namespace Dice.Device.Abstractions
{
    internal abstract class Motion
    {
        public double Axis_X { get; private set; }
        public double Axis_Y { get; private set; }
        public double Axis_Z { get; private set; }

        public void GetAxlesNow()
        {
            Axis_X = AtomMatrix.AccelerometerGyroscope.GetAccelerometer().X;
            Axis_Y = AtomMatrix.AccelerometerGyroscope.GetAccelerometer().Y;
            Axis_Z = AtomMatrix.AccelerometerGyroscope.GetAccelerometer().Z;
        }
    }
}
