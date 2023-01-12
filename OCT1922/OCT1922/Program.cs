using System;
using System.Net.NetworkInformation;

class Methods
{
    public static int DisplayMenu()
    {
        int age;

        Console.WriteLine("Price of Admission");
        Console.WriteLine("Children 6 and under = FREE ($0.00)");
        Console.WriteLine("Students 6-17 = $9.80");
        Console.WriteLine("Adults 18-54 = $11.35");
        Console.WriteLine("Seniors 55+ = $10.00");
        Console.WriteLine();

        Console.Write("Enter your Age: ");
        age = int.Parse(Console.ReadLine());

        return age;
    }

    public static double GetPrice(int age)
    {
        double ticketPrice;

        if (age <= 6)
        {
            ticketPrice = 0;
        }
        else if (age <= 17)
        {
            ticketPrice = 9.8;
        }
        else if (age <= 54)
        {
            ticketPrice = 11.35;
        }
        else
        {
            ticketPrice = 10;
        }

        return ticketPrice;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine($"The Cost of Admission is {GetPrice(DisplayMenu()).ToString("C")}");
    }
}