using System;

class Program
{
    public static void InputDataUser(int[] grades)
    {
        for (int i = 0; i < grades.Length; i++)
        {
            Console.Write($"Enter Element Number {i + 1}: ");
            grades[i] = int.Parse(Console.ReadLine());
        }
    }

    public static void OutputDataUser(int[] grades)
    {
        for (int i = 0; i < grades.Length; i++)
        {
            Console.WriteLine(grades[i]);
        }
    }

    public static void WriteDataFile(int[] grades)
    {
        try
        {
            StreamWriter writer = new StreamWriter("E:/Programming/NOV1422 Files into Arrays/meow.txt");
            for (int i = 0; i < grades.Length; i++)
            {
                writer.WriteLine(grades[i]);
            }
            writer.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
    }

    public static void ReadDataFile(int[] grades)
    {
        try
        {
            StreamReader reader = new StreamReader("E:/Programming/NOV1422 Files into Arrays/meow.txt");
            for (int i = 0; i < grades.Length; i++)
            {
                reader.ReadLine();
            }
            reader.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
    }

    public static void Main(string[] args)
    {
        const int SizeArray = 10;
        int[] scores = new int[SizeArray];

        InputDataUser(scores);
        WriteDataFile(scores);
    }
}