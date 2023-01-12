/*
Purpose:  Lab 2
Input: 2 of (Opposite, Adjacent, Hypotenuse) and a choice to operate the menu
Output: (1 of (Opposite, Adjacent, Hypotenuse) and a Angle based on the two values provided) or an Error
Written by: Andrew Ng
Written for: Harsimranjot Singh Aulakh
Section: A06
Last Modified Date: September 28, 2022
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        // Declaring Variables
        double opposite;
        double adjacent;
        double hypotenuse;
        double angle;
        int menuChoice;

        // Menu
        Console.WriteLine("Solve a right triangle fro the misside side and angle");
        Console.WriteLine("Select from one of the following options");
        Console.WriteLine("\t1. Given Adjacent and Opposite");
        Console.WriteLine("\t2. Given Adjacent and Hypotenuse");
        Console.WriteLine("\t3. Given Opposite and Hypotenuse");

        // User Selects Menu choice
        Console.Write("Option: ");
        menuChoice = int.Parse(Console.ReadLine());

        // Based on Menu choice, Will Do one of three options, or give an error
        switch (menuChoice)
        {
            case 1: // Adjacent and Opposite
                // Get User Input for Adjacent and Opposite
                Console.Write("Side Adjacent: ");
                adjacent = double.Parse(Console.ReadLine());

                Console.Write("Side Opposite: ");
                opposite = double.Parse(Console.ReadLine());

                // No need to test if hypotenuse is greater than either opposite or adjacent as we are trying to find hypotenuse

                // Calculating Values
                hypotenuse = Math.Sqrt(Math.Pow(adjacent, 2) + Math.Pow(opposite, 2));
                angle = Math.Atan(opposite / adjacent) * (180 / Math.PI);

                // Rounding Values
                hypotenuse = Math.Round(hypotenuse, 2);
                angle = Math.Round(angle, 2);

                // Outputting Results
                Console.WriteLine($"Hypotenuse = {hypotenuse}, Angle = {angle}");
                Console.WriteLine("Goodbye");
                break;

            case 2: // Adjacent and Hypotenuse
                // Get User Input for Adjacent and Hypotenuse
                Console.Write("Side Adjacent: ");
                adjacent = double.Parse(Console.ReadLine());

                Console.Write("Side Hypotenuse: ");
                hypotenuse = double.Parse(Console.ReadLine());

                // Testing if Hypotenuse is greater than Adjacent
                if (hypotenuse > adjacent)
                {
                    // Calculating Values
                    opposite = Math.Sqrt(Math.Pow(hypotenuse, 2) - Math.Pow(adjacent, 2));
                    angle = Math.Acos(adjacent / hypotenuse) * (180 / Math.PI);

                    // Rounding Values
                    opposite = Math.Round(opposite, 2);
                    angle = Math.Round(angle, 2);

                    // Outputting Results
                    Console.WriteLine($"Opposite = {opposite}, Angle = {angle}");
                    Console.WriteLine("Goodbye");
                }
                else
                {
                    // Invalid Triangle, Outputs Error Message
                    Console.WriteLine("Invalid triangle, Goodbye");
                }
                break;

            case 3: // Opposite and Hypotenuse
                // Get User Input for Opposite and Hypotenuse
                Console.Write("Side Opposite: ");
                opposite = double.Parse(Console.ReadLine());

                Console.Write("Side Hypotenuse: ");
                hypotenuse = double.Parse(Console.ReadLine());

                // Testing if Hypotenuse is greater than opposite
                if (hypotenuse > opposite)
                {
                    // Calculating Values
                    adjacent = Math.Sqrt(Math.Pow(hypotenuse, 2) - Math.Pow(opposite, 2));
                    angle = Math.Asin(opposite / hypotenuse) * (180 / Math.PI);

                    // Rounding Values
                    adjacent = Math.Round(adjacent, 2);
                    angle = Math.Round(angle, 2);

                    // Outputting Results
                    Console.WriteLine($"Adjacent = {adjacent}, Angle = {angle}");
                    Console.WriteLine("Goodbye");
                }
                else
                {
                    // Invalid Triangle, Outputs Error Message
                    Console.WriteLine("Invalid triangle, Goodbye");
                }
                break;

            default: // If the User Inputs a Invalid Menu Option
                Console.WriteLine("INVALID Selection, Goodbye ...");
                break;
        }
    }
}