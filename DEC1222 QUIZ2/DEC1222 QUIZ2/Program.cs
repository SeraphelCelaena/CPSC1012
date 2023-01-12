using System;

public class QuizMark
{
    //properties
    public int StudentID { get; set; }
    public string QuizName { get; set; }
    public int Mark { get; set; }

    //constructors
    //place your answer here
    public QuizMark(int studentID, string quizName, int mark)
    {
        StudentID = studentID;
        QuizName = quizName;
        Mark = mark;
    }
}

public class Grade
{
    private double _Mark;

    public double Mark
    {
        get
        {
            return _Mark;
        }

        set
        {
            if (value < 0 || value > 100)
            {
                throw new Exception("Invalid mark amount");
            }
            else
            {
                _Mark = value;
            }
        }
    }
}

public class Circle
{
    private double _radius;

    public double Radius
  {  
    get { return _radius; }
    set
    { _radius = value; } 
  }

    public int perimeter(int length, int width)
    {
        // perimeter is the sum of 2 lengths and 2 widths
        return 2 * (length + width);
    }
} 

class Employee
{
    string employeeName;
    double hourlyWage;

    public string EmployeeName
    {
        get { return employeeName; }
        set { employeeName = value; }
    }

    public double HourlyWage
    {
        get { return hourlyWage; }
        set { hourlyWage = value; }
    }

    public Employee(string employeeName, double hourlyWage)
    {
        EmployeeName = employeeName;
        HourlyWage = hourlyWage;
    }   
}

    class Program
{
    static int HighestSales(decimal[] sales, int size)
    {
        decimal highest = 0;
        int highestMonth = 0;

        for (int i = 0; i < sales.Length; i++)
        {
            if (sales[i] > highest)
            {
                highest = sales[i];
                highestMonth = i;
            }
        }

        return highestMonth;
    }

    static void LoadMarks(List<QuizMark> quizzes)
    {
        for (int i = 0; i < quizzes.Count; i++)
        {
            Console.WriteLine($"StudentID = {quizzes[i].StudentID}, Mark = {quizzes[i].Mark}");
        }
    }


    static void Main(string[] args)
    {
        const int Months = 12;
        decimal[] monthlySales = new decimal[Months];
        string[] monthNames = {"January", "February", "March", "April",
                          "May", "June", "July", "August", "September",
                          "October", "November", "December"};
        int index;

        //Assume that there is code here that loads the monthlySales array elements values
        //It is not shown due to space considerations

        //Place your code here to determine the month with the highest sales and display your output.

        double[] doubleValues = new double[25];
        int[] intValues = {1, 2, 3};

        QuizMark[] quizMarkArray = new QuizMark[30];

        string[] actors = { "Moe", "Larry", "Curly" };

        actors[2] = "Shemp";

        List<Employee> listEmployee = new List<Employee>();
        int count = 0;

        try
        {
            StreamReader reader = new StreamReader("c:\\temp\\data.txt");

            while (reader.EndOfStream == false)
            {
                string line = reader.ReadLine();
                string[] lineSplit = line.Split(",");

                listEmployee.Add(new Employee(lineSplit[0], lineSplit[1]));
                count++;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }

        Console.Write($"Reader read {count} lines");

        string[] stringValues = new string[100];

        index = HighestSales(monthlySales, Months);

        Console.WriteLine($"Highest Monthly Sales: {monthNames[index]} had the most sales: {monthlySales[index].ToString("C")}");
    }
}