using System;
using System.Numerics;

namespace Dice.Models {
    public class Sensitivity {
        public int AccPositiveX { get; set; }
        public int AccPositiveY { get; set; }
        public int AccPositiveZ { get; set; }
        public int AccNegativeX { get; set; }
        public int AccNegativeY { get; set; }
        public int AccNegativeZ { get; set; }

        public Sensitivity(int sensitivy) {
            AccPositiveX = sensitivy;
            AccPositiveY = sensitivy;
            AccNegativeZ = sensitivy;
            AccNegativeX = - sensitivy;
            AccNegativeY = - sensitivy;
            AccNegativeZ = - sensitivy;
        }

    }
}
