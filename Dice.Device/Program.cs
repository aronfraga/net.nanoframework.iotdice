namespace Dice.Device
{
    public class Program
    {
        public static void Main()
        {
            Initializer initializer = new Initializer();

            while (true)
            {
                initializer.Start();
            }         
        }
    }
}
