using System;
using System.Numerics;

namespace Dice.Models {
    public class Accelerometer {
        public int AccPositiveX { get; set; }
        public int AccPositiveY { get; set; }
        public int AccPositiveZ { get; set; }
        public int AccNegativeX { get; set; }
        public int AccNegativeY { get; set; }
        public int AccNegativeZ { get; set; }

        public Accelerometer(Sensitivy sensitivy) {
            AccPositiveX = (int)sensitivy;
            AccPositiveY = (int)sensitivy;
            AccNegativeZ = (int)sensitivy;
            AccNegativeX = - (int)sensitivy;
            AccNegativeY = - (int)sensitivy;
            AccNegativeZ = - (int)sensitivy;
        }

    }
}
