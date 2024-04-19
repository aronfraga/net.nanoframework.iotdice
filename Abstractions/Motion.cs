using nanoFramework.AtomMatrix;

namespace Dice.Device.Abstractions
{
    internal abstract class Motion
    {
        protected double Axis_X { get; private set; }
        protected double Axis_Y { get; private set; }
        protected double Axis_Z { get; private set; }

        protected void GetAxlesNow()
        {
            Axis_X = AtomMatrix.AccelerometerGyroscope.GetAccelerometer().X;
            Axis_Y = AtomMatrix.AccelerometerGyroscope.GetAccelerometer().Y;
            Axis_Z = AtomMatrix.AccelerometerGyroscope.GetAccelerometer().Z;
        }
    }
}
