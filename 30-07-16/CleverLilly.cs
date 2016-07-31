using System;

namespace CleverLilly
{
    class CleverLilly
    {
        static void Main()
        {
            // Input
            int age = int.Parse(Console.ReadLine());
            decimal price = decimal.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            decimal totalMoney = 0;
            int toyCount = 0;

            // Logic
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    totalMoney += 10 * i / 2;

                    totalMoney -= 1;
                }
                else
                {
                    toyCount++;
                }
            }
            decimal total = totalMoney + toyCount * toyPrice;

            // Output
            if(total >= price)
            {
                Console.WriteLine($"Yes! {total - price:F2}");
            }
            else
            {
                Console.WriteLine($"No! {price - total:F2}");
            }
        }
    }
}
