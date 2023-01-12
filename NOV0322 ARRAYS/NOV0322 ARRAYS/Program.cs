using System;

class Program
{
    public static void Main(string[] args)
    {
        List<int> intList = new List<int>();
        string input = "0";
        int temp;

        while (input != "")
        {
            Console.Write("Input a Number: ");
            input = Console.ReadLine();
            try
            {
                intList.Add(int.Parse(input));
            }
            catch (Exception e)
            {
                if (input != "")
                {
                    Console.WriteLine($"Error {e.Message}");
                }
            }
        }
        Console.WriteLine(String.Join(", ", intList));

        for (int i = 0; i < intList.Count; i++)
        {
            for (int j = 0; j < intList.Count - 1; j++)
            {
                if (intList[j] > intList[j + 1])
                {
                    temp = intList[j];
                    intList[j] = intList[j + 1];
                    intList[j + 1] = temp;
                }
            }
        }
        Console.WriteLine(String.Join(", ", intList));
    }
}