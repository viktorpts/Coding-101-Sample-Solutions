using System;

namespace OddEvenSum
{
    class OddEvenSum
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int oddSum = 0;
            int evenSum = 0;
            for (int i = 0; i < n; i++)
            {
                int current = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += current;
                }
                else
                {
                    oddSum += current;
                }
            }

            if (evenSum == oddSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {oddSum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(oddSum - evenSum)}");
            }
        }
    }
}
