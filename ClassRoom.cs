using System;

class ClassRoom
{
    static void Main()
    {
        // Input
        int h = (int)(double.Parse(Console.ReadLine()) * 100);
        int w = (int)(double.Parse(Console.ReadLine()) * 100);

        int deskH = 70;
        int deskW = 120;
        int corridorMin = 100;

        // Logic
        int cols = (w - corridorMin) / deskH;
        int rows = h / deskW;
        int desks = cols * rows - 3;

        // Output
        Console.WriteLine(desks);
    }
}
