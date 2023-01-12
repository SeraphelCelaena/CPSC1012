using System;

class Quiz
{
    public static void Main(string[] args)
    {
        int n, m = 1, stepValue, total = 0, meanCount = 0;

        Console.Write("Enter n: ");
        n = int.Parse(Console.ReadLine());

        while (m <= n)
        {
            if (m == 1)
            {
                Console.Write(m);
            }
            else
            {
                Console.Write($" + {m}");
            }
            m++;
        }
        Console.WriteLine();

        m = 1;

        Console.Write("Enter n: ");
        n = int.Parse(Console.ReadLine());

        Console.Write("Enter Step Value: ");
        stepValue = int.Parse(Console.ReadLine());

        while (m <= n)
        {
            if (m == 1)
            {
                Console.Write(m);
            }
            else
            {
                Console.Write($" + {m}");
            }
            total += m;
            m += stepValue;
            meanCount++;
        }
        Console.Write($" = {total}\n");
        Console.WriteLine($"Sum = {total}");
        Console.WriteLine($"Elements = {meanCount}");
        Console.WriteLine($"Average = {total / meanCount}");
    }
}