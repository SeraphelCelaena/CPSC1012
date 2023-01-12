/*
Purpose:  Lab 6
Input: Minutes, Kilometers
Output: Taxi Fare
Written by: Andrew Ng
Written for: Harsimranjot Singh Aulakh
Section: A06
Last Modified Date: December 06, 2022
*/

using System;
using System.ComponentModel;

class Fare
{
    int minutes;
    int distance;

    public int Minutes
    {
        get
        {
            return minutes;
        }

        set
        {
            if (10 > value)
            {
                Console.WriteLine("Invalid Trip Minutes");
                throw new Exception("Invalid Trip Minutes");
            }
            else
            {
                minutes = value;
            }
        }
    }

    public int Distance
    {
        get
        {
            return distance;
        }

        set
        {
            if (2 > value)
            {
                Console.WriteLine("Invalid Trip Kilometers");
                throw new Exception("Invalid Trip Kilometers");
            }
            else
            {
                distance = value;
            }
        }
    }

    public Fare(int minutes, int distance)
    {
        Minutes = minutes;
        Distance = distance;
    }

    public void GetFare()
    {
        double fare;

        fare = ((minutes * 0.25) + (distance * 1.25)) * 1.10;

        Console.WriteLine($"The fare for the passenger(s) is {fare.ToString("C")}");
    }
}

class Program
{
    static string PromptString(string label)
    {
        string userInput;

        Console.Write(label);
        userInput = Console.ReadLine();

        return userInput;
    }

    static int PromptInt(string label)
    {
        int userInput;

        while (true)
        {
            try
            {
                userInput = int.Parse(PromptString(label));
                return userInput;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }

    static int PromptIntPositive(string label)
    {
        int userInput;

        while (true)
        {
            userInput = PromptInt(label);

            if (userInput > 0)
            {
                return userInput;
            }
        }
    }

    public static void Main(string[] args)
    {
        int tripMinutes;
        int tripKilometers;

        Console.WriteLine("Welcome to the Taxi Fare Calculator");
        tripMinutes = PromptIntPositive("Enter the time, in whole minutes, the trip took (min 10 minutes): ");
        tripKilometers = PromptIntPositive("Enter the distance, in whole kilometers, the trip was (min 2 km): ");

        Fare taxiFare = new Fare(tripMinutes, tripKilometers);

        taxiFare.GetFare();
    }
}