namespace SmallestNumber
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

			int minNumber = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                int current = int.Parse(Console.ReadLine());
                
				if (minNumber > current)
				{
					minNumber = current;
				}
            }
            Console.WriteLine(minNumber);
        }
    }
}
