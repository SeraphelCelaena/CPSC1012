/*
Purpose:  Lab 4
Input: Years, Amount
Output: Depreciation Amount
Written by: Andrew Ng
Written for: Harsimranjot Singh Aulakh
Section: A06
Last Modified Date: November 03, 2022
*/

using System;
using System.Runtime.CompilerServices;
using System.Xml;

class Program
{
    public static string PromptString(string label) // Prompts for String and returns a string
    {
        string userInput;

        Console.Write(label);
        userInput = Console.ReadLine();

        return userInput;
    }

    public static int PromptInt(string label) // Prompts for Integer and returns an int
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

    public static char PromptChar(string label) // Prompts for Character and returns a character
    {
        string userInput;

        while (true)
        {
            userInput = PromptString(label);

            if (userInput.Length == 1 && userInput != " ")
            {
                return char.Parse(userInput);
            }
            else
            {
                Console.WriteLine("Input Must be Exactly One Character Long");
            }
        }
    }

    public static char DisplayMenu() // Displays menu and gets userInput
    {
        char userInput;

        Console.WriteLine();
        Console.WriteLine("\tA. Enter a New Amount and Number of Years.");
        Console.WriteLine("\tB. Display Depreciation Table.");
        Console.WriteLine("\tQ. Quit");
        userInput = PromptChar("Choice: ");

        return userInput;
    }

    public static int SumOfDigits(int years) // SumOfDigits function
    {
        int output = 0;

        for (int i = 1; i <= years; i++)
        {
            output += i;
        }

        return output;
    }

    public static void DisplayDepreciation(double amount, int years, double sumYears) // Displays Depreciation Table
    {
        double[] output = new double[years];
        int yearsCount = years;

        // Calculating Depreciation
        for (int i = 0; i < years; i++)
        {
            output[i] = amount * yearsCount / sumYears;
            amount -= output[i];
            sumYears -= yearsCount;
            yearsCount -= 1;
        }

        // Displaying Depreciation Table
        Console.WriteLine("Year   Depreciation");
        for (int i = 0; i < years; i++)
        {
            Console.WriteLine($"{(i+1).ToString().PadLeft(4)}{output[i].ToString("C").PadLeft(15)}");
        }
    }

    public static void Main(string[] args)
    {
        // Declaring Variables
        char menuChoice = 'z'; // Random Value so the while loop does not throw an error
        int amount = 0;
        int years = 0;
        int sumYears = 0;
        bool mainLoop = true;

        // Main Program Loop
        Console.WriteLine("This Program Computes Depreciation Tables Using the sum-of-years-digits method.");
        do
        {
            // Displays menu and gets userInput
            menuChoice = DisplayMenu();

            switch (menuChoice)
            {
                case 'a' or 'A': // Get Values for amount and years
                    amount = PromptInt("Enter Amount to be Depreciated: ");
                    years = PromptInt("Enter Number of Years for Depreciation: ");
                    sumYears = SumOfDigits(years);
                    break;

                case 'b' or 'B': // Displays Depreciation Table if values are given
                    if (sumYears == 0 && amount == 0 && years == 0)
                    {
                        Console.WriteLine("You Must Enter an Amount and Number of Years...");
                    }
                    else
                    {
                        DisplayDepreciation(amount, years, sumYears);
                    }
                    break;

                case 'q' or 'Q': // Quit
                    Console.WriteLine("Goodbye");
                    mainLoop = false;
                    break;
                    
                default:
                    Console.WriteLine("Enter a Valid Choice");
                    break;
            }

        } while (mainLoop == true);
    }
}