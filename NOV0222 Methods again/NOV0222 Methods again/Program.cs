using System;
using System.Linq.Expressions;

class Program
{
    static double InputRadius()
    {
        double userInput = -1;

        while (userInput < 0)
        {
            try
            {
                Console.Write("Enter Radius: ");
                userInput = double.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            if (userInput < 0)
            {
                Console.WriteLine("Enter a Number Greater Than 0");
            }
        }

        return userInput;
    }

    static void CalculateArea(double rad)
    {
        double area;

        area = Math.PI * rad * rad;

        Console.WriteLine($"The Area of the Circle is {area}");
    }

    public static void Main(string[] args)
    {
        CalculateArea(InputRadius());
    }
}