using System;

namespace RectangleWithStars
{
    class RectangleWithStars
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int width = n * 2;
            int height = n + 2 - ((n + 1) % 2);

            for (int row = 0; row < height; row++)
            {
                if (row == 0 || row == height - 1)
                {
                    Console.WriteLine(new string('%', width));
                }
                else if (row == height / 2)
                {
                    string spaces = new string (' ', width /2 - 2);
                    Console.WriteLine("%" + spaces + "**" + spaces + "%");
                }
                else
                {
                    Console.WriteLine("%" + new string(' ', width - 2) + "%");
                }
            }
        }
    }
}
