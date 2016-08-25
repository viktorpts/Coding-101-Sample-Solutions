using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            // For roof
            for (int row = 0; row < n - (n / 2); row++)
            {
                int starCount = (row * 2) + 1 + ((n + 1) % 2);
                string dashes = new string('-', (n - starCount) / 2);
                string stars = new string('*', starCount);
                Console.WriteLine(dashes + stars + dashes);
            }
            // For base
            for (int row = 0; row < n / 2; row++)
            {
                Console.WriteLine("|" + new string('*', n - 2) + "|");
            }
        }
    }
}
