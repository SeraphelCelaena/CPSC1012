/*
Purpose:  Lab 3
Input: startingBalance, annualInterestRate, Years of investing
Output: Each year and what balance you would have with it.
Written by: Andrew Ng
Written for: Harsimranjot Singh Aulakh
Section: A06
Last Modified Date: October 07, 2022
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        // Declaring Variables
        double annualInterest;
        double monthlyInterest; 
        double balance; 
        int yearsInvest; // How Many Years to Save/Invest For
        int yearsCount; // Variable for Keeping Track of Years
        int monthlyCount; // Variable for keeping track of monthly interest

        // Getting User Input
        Console.Write("Enter Starting Balance: ");
        balance = double.Parse(Console.ReadLine());

        Console.Write("Enter Annual Interest Rate (1.5% is inputted as 0.015): ");
        annualInterest = double.Parse(Console.ReadLine());

        Console.Write("Enter Number of Years to Save: ");
        yearsInvest = int.Parse(Console.ReadLine());

        // Calculating Variables that Do not need Looping / Initializing Variables
        yearsCount = 0;
        monthlyInterest = annualInterest / 12;

        // Calculating Yearly Interest and Outputting Results

        while (true)
        {
            // Prints Result first as you need to print initial starting value
            Console.WriteLine($"Year: {yearsCount} {balance.ToString("C")}");

            // Calculates all the interest for a year
            monthlyCount = 1; // Calculates Interest for next year
            while (monthlyCount <= 12)
            {
                balance = balance + balance * monthlyInterest;
                monthlyCount++;
            }

            // Keeps count of years and breaks loop if needed
            yearsCount++;

            if (yearsCount > yearsInvest)
            {
                break;
            }
        }
    }
}