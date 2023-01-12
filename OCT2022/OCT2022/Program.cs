using System;

class MethodPractice
{
    static void DisplayMenu()
    {
        Console.WriteLine("1. Children 6 and Under = Free ($0.00)");
        Console.WriteLine("2. Students 7 to 17 = $9.80");
        Console.WriteLine("3. Adults 18 to 54 = $11.35");
        Console.WriteLine("4. Seniors 55+ = $10.00");
        Console.WriteLine();
    }
    
    static string Prompt(string label)
    {
        string promptOutput;

        Console.Write(label);
        promptOutput = Console.ReadLine();

        return promptOutput;
    }

    static int PromptInt(string label)
    {
        int promptOutput;

        do
        {
            try
            {
                Console.Write(label);
                promptOutput = int.Parse(Console.ReadLine());
                break;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            
        } while (true);
        

        return promptOutput;
    }

    static int PromptPosInt(string label)
    {
        int promptOutput;

        do
        {
            promptOutput = PromptInt(label);

            if (promptOutput < 0)
            {
                Console.WriteLine("Enter a Positive Integer");
            }
        } while (promptOutput < 0);

        return promptOutput;
    }

    static double GetTotal(int pennies, int nickels, int dimes, int quarters, int loonies, int toonies)
    {
        double total = 0;

        total += pennies * 0.01;
        total += nickels * 0.05;
        total += dimes * 0.1;
        total += quarters * 0.25;
        total += loonies;
        total += toonies * 2;

        return total;
    }

    static int GetSeconds(int hours, int minutes, int seconds)
    {
        int totalSeconds = 0;

        totalSeconds += hours * 3600;
        totalSeconds += minutes * 60;
        totalSeconds += seconds;

        return totalSeconds;
    }

    static double TicketPrice(int option)
    {
        double price;

        switch (option)
        {
            case 1:
                price = 0;
                break;
            case 2:
                price = 9.8;
                break;
            case 3:
                price = 11.35;
                break;
            case 4:
                price = 10;
                break;
            default:
                price = 15;
                break;
        }

        return price;
    }

    public static double CalculatePay(int payRate, int hours)
    {
        double pay = 0;

        if (hours > 50)
        {
            pay += payRate * (hours - 50) * 2;
            pay += payRate * 10 * 1.5;
            pay += payRate * 40;
        }
        else if (hours > 40)
        {
            pay += payRate * (hours - 40) * 1.5;
            pay += payRate * 40;
        }
        else
        {
            pay += payRate * hours;
        }

        return pay;
    }

    public static void Main(string[] args)
    {
        /*
        // Ticket Price Stuffs
        double price;

        DisplayMenu();
        price = TicketPrice(PromptPosInt("Choose an Option: "));
        Console.WriteLine($"You have to pay {price.ToString("C")}");
        */

        // Get Change
        int amountPenny, amountNickel, amountDime, amountQuarter, amountLoonie, amountToonie;

        amountPenny = PromptPosInt("Enter Number of Pennies: ");
        amountNickel = PromptPosInt("Enter Number of Nickels: ");
        amountDime = PromptPosInt("Enter Number of Dimes: ");
        amountQuarter = PromptPosInt("Enter Number of Quarters: ");
        amountLoonie = PromptPosInt("Enter Number of Loonies: ");
        amountToonie = PromptPosInt("Enter Number of Toonies: ");

        Console.WriteLine($"The Amount of Change in your Pockets is {GetTotal(amountPenny, amountNickel, amountDime, amountQuarter, amountLoonie, amountToonie).ToString("C")}");


        // Get Seconds
        int amountSeconds, amountMinutes, amountHours;

        amountSeconds = PromptPosInt("Enter Number of Seconds: ");
        amountMinutes = PromptPosInt("Enter Number of Minutes: ");
        amountHours = PromptPosInt("Enter Number of Hours: ");

        Console.WriteLine($"The Amount of Seconds is {GetSeconds(amountHours, amountMinutes, amountSeconds)} Seconds");


        // Get Pay 
        int hoursWorked, payRate;

        hoursWorked = PromptPosInt("Enter Hours Worked");
        payRate = PromptPosInt("Enter Pay Rate");

        Console.WriteLine($"Your wage is ${CalculatePay(payRate, hoursWorked).ToString("C")} this week.");

        // Taxi Program

    }
}