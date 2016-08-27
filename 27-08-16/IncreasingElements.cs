using System;

namespace IncreasingElements
{
    class IncreasingElements
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int prev = int.MinValue;
            int length = 0;
            int maxLength = 0;
            for (int i = 0; i < n; i++)
            {
                int current = int.Parse(Console.ReadLine());

                if (current > prev)
                {
                    length++;
                }
                else
                {
                    if (length > maxLength)
                    {
                        maxLength = length;
                    }
                    length = 1;
                }
                prev = current;
            }
            if (length > maxLength)
            {
                maxLength = length;
            }
            Console.WriteLine(maxLength);
        }
    }
}
