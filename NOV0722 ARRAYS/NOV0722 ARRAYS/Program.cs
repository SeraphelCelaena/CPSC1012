using System;

class Program
{
    public static void Main(string[] args)
    {
        int arraySize;

        Console.Write("Enter Array Length/Width: ");
        arraySize = int.Parse(Console.ReadLine());

        int[,] array2D = new int[arraySize, arraySize];

        for (int i = 0; array2D.GetLength(0) > i; i++)
        {
            for (int j = 0; array2D.GetLength(1) > j; j++)
            {
                array2D[i, j] = (i * arraySize) + j + 1;
            }
        }

        for (int i = 0; array2D.GetLength(0) > i; i++)
        {
            for (int j = 0; array2D.GetLength(1) > j; j++)
            {
                Console.Write($"{array2D[i, j].ToString().PadLeft((array2D.GetLength(0) * array2D.GetLength(1) + 1).ToString().Length)} ");
                if (j == array2D.GetLength(1) - 1)
                {
                    Console.Write("\n");
                }
            }
        }
    }
}