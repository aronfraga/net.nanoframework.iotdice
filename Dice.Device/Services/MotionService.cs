using Dice.Device.Abstractions;
using Dice.Device.Utilities;
using System.Diagnostics;

namespace Dice.Device.Services
{
    internal sealed class MotionService : Motion
    {
        private int _accPositiveX;
        private int _accPositiveY;
        private int _accPositiveZ;
        private int _accNegativeX;
        private int _accNegativeY;
        private int _accNegativeZ;

        private MotionService(Sensitivy sensitivy) : base()
        {
            _accPositiveX = (int)sensitivy;
            _accPositiveY = (int)sensitivy;
            _accPositiveZ = (int)sensitivy;
            _accNegativeX = -(int)sensitivy;
            _accNegativeY = -(int)sensitivy;
            _accNegativeZ = -(int)sensitivy;
        }

        public static bool CriticalMove(Sensitivy sensitivy)
        {
            MotionService motionService = new MotionService(sensitivy);
            motionService.GetAxlesNow();
            bool shake = false;

            if (motionService.Axis_X > motionService._accPositiveX || motionService.Axis_X < motionService._accNegativeX)
            {
                Debug.WriteLine("Throw dice on X axis");
                shake = true;
            }
            if (motionService.Axis_Y > motionService._accPositiveY || motionService.Axis_Y < motionService._accNegativeY)
            {
                Debug.WriteLine("Throw dice on Y axis");
                shake = true;
            }
            if (motionService.Axis_Z > motionService._accPositiveZ || motionService.Axis_Z < motionService._accNegativeZ)
            {
                Debug.WriteLine("Throw dice on Z axis");
                shake = true;
            }

            return shake;
        }
    }
}
