using System;

class Student
{
    string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public Student()
    {

    }


}

class Program
{
    public static void Main(string[] args)
    {
        DateTime birthday;

        Console.Write("Enter Date of Birth: ");
        birthday = DateTime.Parse(Console.ReadLine());

        if (birthday > DateTime.Today)
        {
            Console.WriteLine("Birthdays in the future are not allowed");
        }
        else
        {
            Console.WriteLine(birthday);
        }

        Console.WriteLine(DateTime.Today);
        Console.WriteLine(DateTime.Now);

        Console.WriteLine(DateTime.Today.Month);

        Student st = new Student();
    }
}