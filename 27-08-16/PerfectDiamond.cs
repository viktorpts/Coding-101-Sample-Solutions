using System;

namespace PerfectDiamond
{
    class PerfectDiamond
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int width = 2 * n - 1;

            // Top half
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string(' ', n - 1 - i));
                for (int col = 0; col < (i * 2) + 1; col++)
                {
                    if (col % 2 == 0)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
                Console.WriteLine();
            }

            // Bottom half
            for (int i = n - 2; i >= 0; i--)
            {
                Console.Write(new string(' ', n - 1 - i));
                for (int col = 0; col < (i * 2) + 1; col++)
                {
                    if (col % 2 == 0)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
