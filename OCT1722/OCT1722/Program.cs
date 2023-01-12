/*
 * Methods/Function
 * Types of Methods
 *  - Built in Methods
 *  - User Defined
 * How to Define Methods
 *      // Syntax
 *      static [RETURNDATATYPE] [METHODNAME]([PARAMETERS]) // Method Declaration
 *      {
 *      // CODE // Method Body
 *      }
 * How to call/access Methods
 * how to parse values
 * - By Value
 * - By References
 * How to return data from methods
 */

using System;

class MethodDemo
{
    public static void Display()
    {
        Console.WriteLine("NYANNERS");
    }

    static void Print()
    {
        Console.WriteLine("Second Method in our file :Cheer:");
    }

    public static double AreaOfCircle()
    {
        // Declaring Variables
        double radius = 5.0;
        double area;

        // Calculations
        area = Math.PI * radius * radius;

        return area;
    }

    public static double AreaOfCircle2(double radius)
    {
        double area;

        // Calculations
        area = Math.PI * radius * radius;

        return area;
    }

    public static void Main(string[] args)
    {
        double rad = 6;

        Display();
        Print();
        Console.WriteLine("Area of Circle: " + AreaOfCircle());
        Console.WriteLine("Area of Circle: " + AreaOfCircle2(rad));
    }
}