using System;

namespace Bricks
{
    class Bricks
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine()); // total bricks
            int w = int.Parse(Console.ReadLine()); // number of workers
            int m = int.Parse(Console.ReadLine()); // trolley capacity

            double bricksPerTrip = w * m;
            int totaltrips = (int)Math.Ceiling(x / bricksPerTrip);

            Console.WriteLine(totaltrips);
        }
    }
}
