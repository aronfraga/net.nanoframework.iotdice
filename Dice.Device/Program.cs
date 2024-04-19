using Dice.Device.Utilities;

namespace Dice.Device
{
    public class Program
    {
        public static void Main()
        {
            Settings settings = new Settings();
            Initializer initializer = new Initializer(settings);

            while (true)
            {
                initializer.Start();
            }
        }
    }
}

// Result Pattern
// Debugger
// Initializer, Program, Settings

// Wifi
// Send Event API or Azure
// Clean Packages