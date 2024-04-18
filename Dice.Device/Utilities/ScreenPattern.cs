namespace Dice.Device.Utilities
{
    internal sealed class ScreenPattern
    {
        private readonly short[] NumberOne       = { 2, 2 };
        private readonly short[] NumberTwo       = { 0, 0, 4, 4 };
        private readonly short[] NumberThree     = { 0, 0, 2, 2, 4, 4 };
        private readonly short[] NumberFour      = { 0, 0, 0, 4, 4, 0, 4, 4 };
        private readonly short[] NumberFive      = { 0, 0, 0, 4, 2, 2, 4, 0, 4, 4 };
        private readonly short[] NumberSix       = { 0, 0, 0, 4, 0, 2, 4, 2, 4, 0, 4, 4 };

        private readonly short[] ThrowAnimation  = { 2, 2, 5,
                                                     0, 0, 4, 4, 5,
                                                     0, 0, 2, 2, 4, 4, 5,
                                                     0, 0, 0, 4, 4, 0, 4, 4, 5,
                                                     0, 0, 0, 4, 2, 2, 4, 0, 4, 4, 5,
                                                     0, 0, 0, 4, 0, 2, 4, 2, 4, 0, 4, 4, 5 };

        private readonly short[] LoadAnimation   = { 1, 1, 1, 2, 1, 3, 2, 1, 2, 3, 3, 1, 3, 3, 5,
                                                     1, 1, 1, 2, 1, 3, 2, 1, 2, 3, 3, 1, 3, 2, 5,
                                                     1, 1, 1, 2, 1, 3, 2, 1, 3, 1, 3, 2, 3, 3, 5,
                                                     1, 1, 1, 2, 2, 1, 2, 3, 3, 1, 3, 2, 3, 3, 5,
                                                     1, 1, 1, 3, 2, 1, 2, 3, 3, 1, 3, 2, 3, 3, 5,
                                                     1, 2, 1, 3, 2, 1, 2, 3, 3, 1, 3, 2, 3, 3, 5,
                                                     1, 1, 1, 2, 1, 3, 2, 3, 3, 1, 3, 2, 3, 3, 5,
                                                     1, 1, 1, 2, 1, 3, 2, 1, 2, 3, 3, 2, 3, 3, 5 };

        private readonly short[] HappyEmoticon   = { 0, 3, 1, 0, 1, 1, 1, 4, 2, 4, 3, 0, 3, 1, 3, 4, 4, 3 };
        private readonly short[] TemperatureHigh = { 2, 0, 2, 1, 2, 2, 2, 4 };
        private readonly short[] SystemError     = { };

        public short[] GetMatrixPattern(Pattern pattern)
        {
            return pattern switch
            {
                Pattern.One             => NumberOne,
                Pattern.Two             => NumberTwo,
                Pattern.Three           => NumberThree,
                Pattern.Four            => NumberFour,
                Pattern.Five            => NumberFive,
                Pattern.Six             => NumberSix,
                Pattern.ThrowAnimation  => ThrowAnimation,
                Pattern.LoadAnimation   => LoadAnimation,
                Pattern.HappyEmoticon   => HappyEmoticon,
                Pattern.TemperatureHigh => TemperatureHigh,
                                      _ => SystemError
            };
        }
    }
}
