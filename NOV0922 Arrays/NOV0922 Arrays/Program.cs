using System;

class Program
{
    public static void DisplayArray(int[] grades)
    {
        for (int i = 0; i < grades.Length; i++)
        {
            Console.WriteLine(grades[i]);
        }
    }

    public static void Main(string[] args)
    {
        int[] marks = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        DisplayArray(marks);
    }
}