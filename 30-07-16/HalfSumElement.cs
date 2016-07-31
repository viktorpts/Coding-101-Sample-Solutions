using System;

namespace HalfSumElement
{
    class HalfSumElement
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int maxElement = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int current = int.Parse(Console.ReadLine());

                sum += current;
                if (maxElement < current)
                {
                    maxElement = current;
                }
            }
            if (2 * maxElement == sum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {maxElement}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sum - 2 * maxElement)}");
            }
        }
    }
}
