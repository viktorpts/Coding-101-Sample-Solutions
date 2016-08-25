using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4
{
    class Demo4
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n <= 2)
            {
                Console.WriteLine(new string('*', n));
                return;
            }

            int half = (n - 1) / 2;

            int middle = 1 + ((n + 1) % 2);
            int dashesCount = (n - middle) / 2 - 1;
            int innerCount = 0;
            for (int i = 0; i < half; i++)
            {
                if (i == 0)
                {
                    string dashes = new string('-', dashesCount + 1);
                    string stars = new string('*', middle);
                    Console.WriteLine(dashes + stars + dashes);
                }
                else
                {
                    string middleDashes = new string('-', middle);
                    string dashes = new string('-', dashesCount);
                    string innerDashes = new string('-', innerCount);
                    Console.WriteLine(dashes + "*" + innerDashes + middleDashes + innerDashes + "*" + dashes);
                    dashesCount--;
                    innerCount++;
                }
            }
            Console.WriteLine("*" + new string('-', n - 2) + "*");
            for (int i = half - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    string dashes = new string('-', (n - middle) / 2);
                    string stars = new string('*', middle);
                    Console.WriteLine(dashes + stars + dashes);
                }
                else
                {
                    dashesCount++;
                    innerCount--;
                    string middleDashes = new string('-', middle);
                    string dashes = new string('-', dashesCount);
                    string innerDashes = new string('-', innerCount);
                    Console.WriteLine(dashes + "*" + innerDashes + middleDashes + innerDashes + "*" + dashes);
                }
            }
        }
    }
}
