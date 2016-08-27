using System;

namespace Increasing4Numbers
{
    class Increasing4Numbers
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (b - a < 3)
            {
                Console.WriteLine("No");
                return;
            }

            for (int i = a; i <= b - 3; i++)
            {
                for (int j = i + 1; j <= b - 2; j++)
                {
                    for (int k = j + 1; k <= b - 1; k++)
                    {
                        for (int l = k + 1; l <= b; l++)
                        {
                            Console.WriteLine($"{i} {j} {k} {l}");
                        }
                    }
                }
            }
        }
    }
}
