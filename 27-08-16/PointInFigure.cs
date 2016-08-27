using System;

namespace PointInFigure
{
    class PointInFigure
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int r1x1 = 2;
            int r1y1 = -3;
            int r1x2 = 12;
            int r1y2 = 1;

            int r2x1 = 4;
            int r2y1 = -5;
            int r2x2 = 10;
            int r2y2 = 3;

            // Check first rectangle
            if (CheckRectangle(r1x1, r1x2, r1y1, r1y2, x, y) ||
                CheckRectangle(r2x1, r2x2, r2y1, r2y2, x, y))
            {
                Console.WriteLine("in");
            }
            else
            {
                Console.WriteLine("out");
            }
        }

        static bool CheckRectangle(int x1, int x2, int y1, int y2, int x, int y)
        {
            if (x >= x1 && x <= x2 &&
                y >= y1 && y <= y2)
            {
                // Inside
                return true;
            }
            return false;
        }
    }
}
