using System;

namespace TriangleArea
{
    class TriangleArea
    {
        static void Main()
        {
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int x3 = int.Parse(Console.ReadLine());
            int y3 = int.Parse(Console.ReadLine());

            int h = Math.Abs(y2 - y1);
            int side = Math.Abs(x3 - x2);

            Console.WriteLine(side * h / 2.0);
        }
    }
}
