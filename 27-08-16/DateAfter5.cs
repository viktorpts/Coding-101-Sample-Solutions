using System;

namespace DateAfter5
{
    class DateAfter5
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());

            int daysInMonth = 31;
            if (month == 2)
            {
                daysInMonth = 28;
            }
            else if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                daysInMonth = 30;
            }

            day += 5;
            if (day > daysInMonth)
            {
                day -= daysInMonth;
                month++;
            }
            if (month > 12)
            {
                month = 1;
            }

            Console.WriteLine($"{day}.{month:00}");
        }
    }
}
