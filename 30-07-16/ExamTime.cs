namespace ExamTime
{
    using System;

    class ExamTime
    {
        static void Main()
        {
            // Input
            int examHours = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arrHours = int.Parse(Console.ReadLine());
            int arrMinutes = int.Parse(Console.ReadLine());

            // Logic
            int examTime = examHours * 60 + examMinutes;
            int arrTime = arrHours * 60 + arrMinutes;

            int difference = arrTime - examTime;
            string differenceAsString = "";
            if (Math.Abs(difference) >= 60)
            {
                int hours = Math.Abs(difference) / 60;
                int minutes = Math.Abs(difference) % 60;
                differenceAsString = $"{hours}:{minutes:00} hours";
            }
            else
            {
                differenceAsString = $"{Math.Abs(difference)} minutes";
            }

            // Output
            if (difference > 0)
            {
                Console.WriteLine("Late");
                Console.WriteLine($"{differenceAsString} after the start");
            }
            else if (difference >= -30)
            {
                Console.WriteLine("On time");
                Console.WriteLine($"{differenceAsString} before the start");
            }
            else
            {
                Console.WriteLine("Early");
                Console.WriteLine($"{differenceAsString} before the start");
            }
        }
    }
}
