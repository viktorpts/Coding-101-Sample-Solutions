using System;

class PipesInAPoll
{
    static void Main()
    {
        // Input
        int volume = int.Parse(Console.ReadLine());
        int pipe1 = int.Parse(Console.ReadLine());
        int pipe2 = int.Parse(Console.ReadLine());
        double time = double.Parse(Console.ReadLine());

        // Logic
        double pipe1Total = pipe1 * time;
        double pipe2Total = pipe2 * time;
        double total = pipe1Total + pipe2Total;
        double totalPercent = total / volume * 100;
        double pipe1Percent = pipe1Total / total * 100;
        double pipe2Percent = pipe2Total / total * 100;

        // Output
        if (total > volume)
        {
            double overflow = total - volume;
            Console.WriteLine("For {0} hours the pool overflows with {1} liters.", time, overflow);
        }
        else
        {
            Console.WriteLine("The pool is {0:f0} % full. Pipe 1: {1:f0} %. Pipe 2: {2:f0} %.", Math.Floor(totalPercent), Math.Floor(pipe1Percent), Math.Floor(pipe2Percent));
        }
    }
}