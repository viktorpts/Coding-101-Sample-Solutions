using System;

namespace GenerateRectangles
{
    class GenerateRectangles
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            bool found = false;
            for (int x1 = -n; x1 < n; x1++)
            {
                for (int y1 = -n; y1 < n; y1++)
                {
                    for (int x2 = x1 + 1; x2 <= n; x2++)
                    {
                        for (int y2 = y1 + 1; y2 <= n; y2++)
                        {
                            int width = Math.Abs(x2 - x1);
                            int height = Math.Abs(y2 - y1);
                            int area = width * height;
                            if (area >= m)
                            {
                                found = true;
                                Console.WriteLine($"({x1}, {y1}) ({x2}, {y2}) -> {area}");
                            }
                        }
                    }
                }
            }
            if (!found)
            {
                Console.WriteLine("No");
            }
        }
    }
}
