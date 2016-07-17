using System;

class Pipes
{
    static void Main()
    {
        // Input
        int Volume = int.Parse(Console.ReadLine()); // hdoahd
        int P1 = int.Parse(Console.ReadLine());
        int P2 = int.Parse(Console.ReadLine());
        double H = double.Parse(Console.ReadLine());

        double P1Total;
        double P2Total;
        double Total;

        // Logic
        P1Total = P1 * H;
        P2Total = P2 * H;
        Total = P1Total + P2Total;

        // Output
        if (Total > Volume)
        {
            // Overflow
            Console.WriteLine("For {0} hours the pool overflows with {1} liters.", H, Total - Volume);
        }
        else
        {
            // Percent full
            int PercentFull = (int)(Total / Volume * 100);
            int P1Percent = (int)(P1Total / Total * 100);
            int P2Percent = (int)(P2Total / Total * 100);
            Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", PercentFull, P1Percent, P2Percent);
        }
    }
}
