using System;

namespace PointInSegment
{
    class PointInSegment
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int point = int.Parse(Console.ReadLine());

            if (point >= Math.Min(first,second) && point <= Math.Max(first, second))
            {
                Console.WriteLine("in");
            }
            else
            {
                Console.WriteLine("out");
            }
            int distance1 = Math.Abs(first - point);
            int distance2 = Math.Abs(second - point);
            Console.WriteLine(Math.Min(distance1, distance2));
        }
    }
}
