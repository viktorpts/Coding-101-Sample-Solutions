using System;

namespace SumStep3
{
    class SumStep3
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;
            for (int i = 1; i <= n; i++)
            {
                int current = int.Parse(Console.ReadLine());
                
                if ((i - 1) % 3 == 0) //1, 4, 7, ...
                {
                    sum1 += current;
                }
                else if ((i + 1) % 3 == 0) //2, 5, 8, ...
                {
                    sum2 += current;
                }
                else //3, 6, 9, ...
                {
                    sum3 += current;
                }
            }

            Console.WriteLine($"sum1 = {sum1}");
            Console.WriteLine($"sum2 = {sum2}");
            Console.WriteLine($"sum3 = {sum3}");
        }
    }
}
