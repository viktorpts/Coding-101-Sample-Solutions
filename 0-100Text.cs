using System;

class Text1_100
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        int tens = input / 10;
        int ones = input % 10;

        string[] smallNums = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        string[] teenNums = { "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};
        string[] bigNums = { "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };

        if (input < 0 || input > 100)
        {
            Console.WriteLine("invalid number");
            return;
        }
        if (input == 100) Console.WriteLine("one hundred");
        else if (tens == 0)
        {
            // 0-9
            Console.WriteLine(smallNums[ones]);
        }
        else if (tens < 2)
        {
            // 10-19
            if (ones == 0) Console.WriteLine("ten");
            else Console.WriteLine(teenNums[ones-1]);
        }
        else
        {
            // 20+
            if (ones == 0) Console.WriteLine("{0}", bigNums[tens - 2]);
            else Console.WriteLine("{0} {1}", bigNums[tens - 2], smallNums[ones]);
        }
    }
}
