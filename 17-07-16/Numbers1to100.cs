using System;

class Program
{
    static void Main()
    {
        // Input
        int n = int.Parse(Console.ReadLine());

        string firstString = "";
        string secondSring = "";

        int tens = n / 10;
        int ones = n % 10;

        // Logic
        if (n < 0 || n > 100)
        {
            Console.WriteLine("invalid number");
            return;
        }
        else if (n == 0)
        {
            Console.WriteLine("zero");
            return;
        }
        else if (n == 100)
        {
            Console.WriteLine("one hundred");
            return;
        }
        else if (n > 10 && n < 20)
        {
            switch (n)
            {
                case 11:
                    secondSring = "eleven";
                    break;
                case 12:
                    secondSring = "twelve";
                    break;
                case 13:
                    secondSring = "thirteen";
                    break;
                case 14:
                    secondSring = "fourteen";
                    break;
                case 15:
                    secondSring = "fifteen";
                    break;
                case 16:
                    secondSring = "sixteen";
                    break;
                case 17:
                    secondSring = "seventeen";
                    break;
                case 18:
                    secondSring = "eighteen";
                    break;
                case 19:
                    secondSring = "nineteen";
                    break;
            }
        }
        else
        {
            switch (tens)
            {
                case 1:
                    firstString = "ten";
                    break;
                case 2:
                    firstString = "twenty";
                    break;
                case 3:
                    firstString = "thirty";
                    break;
                case 4:
                    firstString = "fourty";
                    break;
                case 5:
                    firstString = "fifty";
                    break;
                case 6:
                    firstString = "sixty";
                    break;
                case 7:
                    firstString = "seventy";
                    break;
                case 8:
                    firstString = "eighty";
                    break;
                case 9:
                    firstString = "ninety";
                    break;
            }
            switch (ones)
            {
                case 0:
                    secondSring = "";
                    break;
                case 1:
                    secondSring = "one";
                    break;
                case 2:
                    secondSring = "two";
                    break;
                case 3:
                    secondSring = "three";
                    break;
                case 4:
                    secondSring = "four";
                    break;
                case 5:
                    secondSring = "five";
                    break;
                case 6:
                    secondSring = "six";
                    break;
                case 7:
                    secondSring = "seven";
                    break;
                case 8:
                    secondSring = "eight";
                    break;
                case 9:
                    secondSring = "nine";
                    break;
            }
        }

        // Output
        if (tens == 0 || (n > 10 && n < 20))
        {
            Console.WriteLine(secondSring);
        }
        else if (ones == 0)
        {
            Console.WriteLine(firstString);
        }
        else
        {
            Console.WriteLine("{0} {1}", firstString, secondSring);
        }
    }
}
