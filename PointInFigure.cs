using System;

class PointInFigure
{
    static void Main(string[] args)
    {
        // Input
        double h = double.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        // Logic
        double r1x1 = 0;
        double r1x2 = 3 * h;
        double r1y1 = 0;
        double r1y2 = h;

        double r2x1 = h;
        double r2x2 = 2 * h;
        double r2y1 = h;
        double r2y2 = 4 * h;

        // Checks
        bool isInRec1 = x >= r1x1 && x <= r1x2 && y >= r1y1 && y <= r1y2;
        bool isInRec2 = x >= r2x1 && x <= r2x2 && y >= r2y1 && y <= r2y2;
        bool isBorder1 = (x == r1x1 || x == r1x2 || y == r1y1 || y == r1y2) && isInRec1;
        bool isBorder2 = (x == r2x1 || x == r2x2 || y == r2y1 || y == r2y2) && isInRec2;
        bool except = x > r2x1 && x < r2x2 && y == r2y1;

        // Output
        if (isInRec1 || isInRec2)
        {
            // Inside
            if ((isBorder1 || isBorder2) && !except)
            {
                // Border
                Console.WriteLine("border");
            }
            else
            {
                Console.WriteLine("inside");
            }
        }
        else
        {
            Console.WriteLine("outside");
        }

    }
}
