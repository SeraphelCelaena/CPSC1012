/*
Purpose:  Lab 5
Input: Data Text File
Output: marks
Written by: Andrew Ng
Written for: Harsimranjot Singh Aulakh
Section: A06
Last Modified Date: November 19, 2022
*/

using System;

class Program
{
    public static int LoadData(string filePath, double[] marks)
    {
        int i = 0;

        try
        {
            StreamReader reader = new StreamReader(filePath);
            
            while (reader.EndOfStream == false)
            {
                marks[i] = double.Parse(reader.ReadLine());
                i++;
            }

            reader.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine($"The File, {filePath}, does not exist!");
        }
        return i;
    }

    public static void DisplayMarks(double[] marks, int markCount)
    {
        int i = 1;

        Console.WriteLine($"Quiz Marks: Quiz Total = {marks[0]}");
        Console.WriteLine("Mark   Percentage");
        while (i < markCount)
        {
            Console.WriteLine($"{marks[i].ToString().PadLeft(4)}   {(Math.Round((marks[i] / marks[0]), 4) * 100).ToString("0.00")}%");
            i++;
        }
    }

    public static double AveragePercentage(double[] marks, int markCount)
    {
        double average = 0;
        int i = 1;

        while (i < markCount)
        {
            average += marks[i] / marks[0];
            i++;
        }

        average = average / (markCount - 1) * 100;
        average = Math.Round(average, 2);

        return average;
    }

    public static void DisplayPassFail(double[] marks, int markCount)
    {
        int i = 1;
        int pass = 0;
        int fail = 0;
        double mark;

        while (i < markCount)
        {
            mark = marks[i] / marks[0] * 100;

            if (mark >= 50)
            {
                pass++;
            }
            else
            {
                fail++;
            }
            i++;
        }

        Console.WriteLine($"There were {pass} passes and {fail} fails.");
    }

    public static void Main(string[] args)
    {
        double[] marks = new double[25];
        double average;
        int markCount;

        Console.WriteLine("Welcome to the Quiz Mark Calculator");
        Console.WriteLine("===================================");
        Console.WriteLine();

        markCount = LoadData("G:/Programming/LAB5/LAB5/QuizMark.txt", marks);
        DisplayMarks(marks, markCount);

        average = AveragePercentage(marks, markCount);
        Console.WriteLine($"The Class Average is {average.ToString("0.00")}%");

        DisplayPassFail(marks, markCount);
    }
}