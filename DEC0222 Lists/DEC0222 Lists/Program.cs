using System;
using System.Collections.Immutable;

class Student // Class
{
    int id; // Fields or Data Members
    double marks;

    public int ID // Defining Property
    {
        get // Accessor or Getter Method
        {
            return id;
        }

        set // Mutator or Setter Method
        {
            if (value < 0)
            {
                throw new Exception("Nevative Value is not allowed");
            }
            else
            {
                id = value;
            }
        }
    } // Fully Impletemented Property

    public double Marks 
    {
        get;
        set;
    } // Auto Implemented Property
}

class Program
{
    public static void Main(string[] args)
    {
        List<Student> studentData = new List<Student>();

        List<string> studentNames = new List<string>(); // we do not pass capacity of list

        studentNames.Insert(1, "meow");

        studentNames.Remove("asdddddd");
        studentNames.RemoveAt(0);
        studentNames.RemoveRange(0,2);

        Console.Write("Enter Name of Student: ");
        studentNames.Add(Console.ReadLine());

        int index = studentNames.IndexOf("meow");
    }
}