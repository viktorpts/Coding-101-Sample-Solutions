using System;

class Time15
{
    static void Main()
    {
        // Input
        int hours = int.Parse(Console.ReadLine());
        int mins = int.Parse(Console.ReadLine());

        int totalMins = hours * 60 + mins;
        totalMins += 15;

        // Logic
        int newHours = (totalMins / 60) % 24;
        int newMins = totalMins % 60;

        // Output
        Console.WriteLine("{0}:{1}", newHours, newMins.ToString().PadLeft(2, '0'));
    }
}