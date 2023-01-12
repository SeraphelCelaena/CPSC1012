/*
Purpose: Assignment 1
Inputs: Values of what someone would want to give a unicorn
Outputs: The Price of all the stuff to sponsor a unicorn.
Written By: Andrew Ng
Written For: Harsimranjot Singh Aulakh
Section: A06
Last Modified Date: October 15, 2022
Test Plan: Included in Provided Word Document
 */

using System;

class Program
{
    static void Main(string[] args)
    {
        // Declaring Variables
        string nameSponsor; // Sponsor Name
        string nameUnicorn; // Unicorn Name

        char donationType; // Menu Selector
        int donationMoney = 0; // Money per month
        int donationMonths; // Amount of Months
        int donationTotal = 0; // Total Donation Amount

        int wallSideWidth; // Side Wall Width
        int wallBackWidth; // Back Wall Width
        int wallSideArea; // Side Wall Area
        int wallBackArea; // Back Wall Area
        int wallFrontArea; // Front Wall Area (wallBackArea - gateArea)
        int wallTotal; // Wall Total Cost (2 * wallSideArea + wallBackArea + wallFrontArea)

        int gateWidth; // Gate Width
        int gateHeight; // Gate Height
        int gateArea; // Gate Area
        char gateType; // Gate Type Selector
        int gateTypePrice = 0; // Price of Gate per Square Foot
        char gatePaint; // Y/N
        char gatePaintType; // Gate Paint Type Selector
        int gatePaintTotal = 0; // Gate Paint Total Cost
        int gateTotal; // Total Gate Cost

        char mealUpgrade; // Y/N
        char mealUpgradeType; // Meal Upgrade Selector
        int mealTotal = 0; // Meal Total Cost

        int totalSponsorCost;

        // Program Title
        Console.WriteLine("*** Unicorn Rescue Society Sponsor Estimator");
        Console.WriteLine();

        // Getting name of Sponsor and Unicorn
        Console.Write("Name of Sponsor: ");
        nameSponsor = Console.ReadLine();

        Console.Write("Name of Unicorn: ");
        nameUnicorn = Console.ReadLine();
        Console.WriteLine();

        // Donation Menu
        Console.WriteLine("All Sponsors Must Donate");
        Console.WriteLine("Donation Type Selection");
        Console.WriteLine("\tU - Unlimited; Same Amount for Each Month Forever");
        Console.WriteLine("\tM - Monthly; Same Amount for Each Month for a Predetermined Number of Months");
        Console.WriteLine("\tO - One Time; One Time Donation Amount");

        // Donation Input
        Console.Write("Donation Type: ");
        donationType = char.Parse(Console.ReadLine());

        // Calculating Total Donation Amount
        switch (donationType)
        {
            case 'u' or 'U': // Unlimited
                Console.Write("Donation Amount Per Month: ");
                donationMoney = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine($"Monthly Donation Amount is {donationMoney.ToString("C")}");
                break;

            case 'm' or 'M': // Monthly
                Console.Write("Donation Amount Per Month: ");
                donationMoney = int.Parse(Console.ReadLine());

                Console.Write("Amount of Months to Donate: ");
                donationMonths = int.Parse(Console.ReadLine());
                Console.WriteLine();

                donationTotal = donationMoney * donationMonths;

                Console.WriteLine($"Total Donation Amount is {donationTotal.ToString("C")}");
                break;

            case 'o' or 'O': // One-Time
                Console.Write("Donation Amount: ");
                donationTotal = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine($"Donation Amount is {donationTotal.ToString("C")}");
                break;
        }
        Console.WriteLine();

        // Getting Pen Accomodation Dimensions
        Console.WriteLine("*** Pen Accomodation Dimensions ***");
        Console.Write("Width of Side Wall in Feet: ");
        wallSideWidth = int.Parse(Console.ReadLine());

        Console.Write("Width of Back Wall in Feet: ");
        wallBackWidth = int.Parse(Console.ReadLine());
        Console.WriteLine();

        // Getting Gate Dimensions
        Console.Write("Width of Gate in Feet: ");
        gateWidth = int.Parse(Console.ReadLine());

        Console.Write("Height of Gate in Feet: ");
        gateHeight = int.Parse(Console.ReadLine());
        Console.WriteLine();

        // Gate Style
        Console.WriteLine("*** Gate Style Selection ***");
        Console.WriteLine("\tW - Wooden ($3)");
        Console.WriteLine("\tS - Silver ($8)");
        Console.WriteLine("\tG - Gold ($12)");

        Console.Write("Select a Gate Style: ");
        gateType = char.Parse(Console.ReadLine());
        Console.WriteLine();

        switch (gateType)
        {
            case 'w' or 'W': // Wooden
                gateTypePrice = 3;
                break;

            case 's' or 'S': // Silver
                gateTypePrice = 8;
                break;

            case 'g' or 'G': // Gold
                gateTypePrice = 12;
                break;
        }

        // Gate Paint Y/N
        Console.Write("Would You Like to Change the Gate Paint (Y/N): ");
        gatePaint = char.Parse(Console.ReadLine());

        // Gate Paint Selector
        if (gatePaint == 'y' || gatePaint == 'Y')
        {
            Console.WriteLine("Gate Paint Selection");
            Console.WriteLine("\tM - Mood ($200): Changes Colour Based on the Unicorn's Mood");
            Console.WriteLine("\tA - Magic ($300): Changes Colour Several Times a Day");
            Console.WriteLine("\tR - Reflective ($150): Acts like a Mirror");

            Console.Write("Select Gate Paint: ");
            gatePaintType = char.Parse(Console.ReadLine());

            switch (gatePaintType)
            {
                case 'm' or 'M': // Mood Paint
                    gatePaintTotal = 200;
                    break;

                case 'a' or 'A': // Magic Paint
                    gatePaintTotal = 300;
                    break;

                case 'r' or 'R': // Reflective Paint
                    gatePaintTotal = 150;
                    break;
            }
        }
        Console.WriteLine();

        // Calculating Gate Cost
        gateArea = gateWidth * gateHeight;
        gateTotal = gateArea * gateTypePrice;

        // Calculating Wall Cost
        wallBackArea = wallBackWidth * 12;
        wallSideArea = wallSideWidth * 12 * 2;
        wallFrontArea = wallBackArea - gateArea;
        wallTotal = (wallBackArea + wallSideArea + wallFrontArea) * 4;

        // Meal Upgrade Y/N
        Console.Write("Would You Like a Meal Upgrade (Y/N): ");
        mealUpgrade = char.Parse(Console.ReadLine());

        // Meal Upgrade Selector
        if (mealUpgrade == 'y' || mealUpgrade == 'Y')
        {
            Console.WriteLine("Available Meal Upgrades");
            Console.WriteLine("\tR - Add Rainbow Cookie Treats ($1000)");
            Console.WriteLine("\tS - Special Appetizers ($500)");

            Console.Write("Select Meal Upgrade: ");
            mealUpgradeType = char.Parse(Console.ReadLine());

            switch (mealUpgradeType)
            {
                case 'r' or 'R': // Rainbow Cookie Treats
                    mealTotal = 1000;
                    break;

                case 's' or 'S': // Special Appetizers
                    mealTotal = 500;
                    break;
            }
        }
        Console.WriteLine();

        // Summary
        Console.WriteLine("*** Summary ***");
        Console.WriteLine();
        Console.WriteLine($"Sponsor{nameSponsor.PadLeft(30)}");
        Console.WriteLine($"Unicorn Name{nameUnicorn.PadLeft(25)}");
        
        if (donationType == 'u' || donationType == 'U')
        {
            Console.WriteLine($"Monthly Donation{donationMoney.ToString("C").PadLeft(21)}");
        }
        else
        {
            Console.WriteLine($"Donation Amount{donationTotal.ToString("C").PadLeft(22)}");
        }

        Console.WriteLine($"Wall Cost{wallTotal.ToString("C").PadLeft(28)}");
        Console.WriteLine($"Gate Cost{gateTotal.ToString("C").PadLeft(28)}");

        if (gatePaint == 'y' || gatePaint == 'Y')
        {
            Console.WriteLine($"Gate Paint Cost{gatePaintTotal.ToString("C").PadLeft(22)}");
        }
        else
        {
            Console.WriteLine($"Gate Paint Cost{"Original".PadLeft(22)}");
        }

        if (mealUpgrade == 'y' || mealUpgrade == 'Y')
        {
            Console.WriteLine($"Meal Upgrade{mealTotal.ToString("C").PadLeft(25)}");
        }
        else
        {
            Console.WriteLine($"Meal Upgrade{"None".PadLeft(25)}");
        }
        Console.WriteLine();

        if (donationType == 'u' || donationType == 'U')
        {
            totalSponsorCost = wallTotal + gateTotal + gatePaintTotal + mealTotal;

            Console.WriteLine($"{nameSponsor}, the Total to Sponsor {nameUnicorn} is {totalSponsorCost.ToString("C")} plus {donationMoney.ToString("C")} per Month");
        }
        else
        {
            totalSponsorCost = donationTotal + wallTotal + gateTotal + gatePaintTotal + mealTotal;

            Console.WriteLine($"{nameSponsor}, the Total to Sponsor {nameUnicorn} is {totalSponsorCost.ToString("C")}");
        }
    }
}