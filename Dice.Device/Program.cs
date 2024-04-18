using System;
using System.Diagnostics;
using System.Threading;

namespace Dice.Device
{
    public class Program
    {
        public static void Main()
        {
            Debug.WriteLine("Hello from nanoFramework!");

            Initializer initializer = new Initializer();

            while (true)
            {
                initializer.Start(); // test class
            }
            
            //Thread.Sleep(Timeout.Infinite);
        }
    }
}
