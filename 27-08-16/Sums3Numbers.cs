using System;
using System.Collections.Generic;

namespace Sums3Numbers
{
    class Sums3Numbers
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            if (num2 > num3)
            {
                int temp = num3;
                num3 = num2;
                num2 = temp;
            }
            if (num1 > num2)
            {
                int temp = num2;
                num2 = num1;
                num1 = temp;
            }
            if (num2 > num3)
            {
                int temp = num3;
                num3 = num2;
                num2 = temp;
            }

            if (num1 + num2 == num3)
            {
                Console.WriteLine($"{num1} + {num2} = {num3}");
            }
            else
            {
                Console.WriteLine("No");
            }

            // Solution using Lists
            /*
            List<int> numbers = new List<int>();
            numbers.Add(int.Parse(Console.ReadLine()));
            numbers.Add(int.Parse(Console.ReadLine()));
            numbers.Add(int.Parse(Console.ReadLine()));
            numbers.Sort();
            if (numbers[0] + numbers[1] == numbers[2])
            {
                Console.WriteLine($"{numbers[0]} + {numbers[1]} = {numbers[2]}");
            }
            else
            {
                Console.WriteLine("No");
            }
            */
        }
    }
}
