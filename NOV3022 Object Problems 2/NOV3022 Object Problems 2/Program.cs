using System;
using System.Reflection;

class Quiz
{
    string studentName; // data members or fields
    int total;
    int mark;
    int weight;

    // property
    public string Name
    {
        set
        {
            studentName = value;
        }

        get
        {
            return studentName;
        }
    }

    public Quiz(int total, int weight)
    {
        this.total = total;
        this.weight = weight;
    }

    public int GetMark()
    {
        return mark;
    }

    public int GetTotal()
    {
        return total;
    }

    public int GetWeight()
    {
        return weight;
    }

    public int GetPercentage()
    {
        return (int)total / mark;
    }

    public void SetMark(int mark)
    {
        this.mark = mark;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Quiz[] quizzes = new Quiz[25];
        const int Total = 100;
        const int Weight = 10;
        int tempStudentName;
        int tempMark;

        Console.WriteLine("Enter Quizzes");
        for (int i = 0; i < quizzes.Length; i++)
        {
            quizzes[i] = new Quiz(Total, Weight);
            Console.Write($"Enter Student #{i+1} Name: ");
            quizzes[i].Name = Console.ReadLine();

            Console.WriteLine($"Enter {quizzes[i].Name}'s Mark: ");
            quizzes[i].SetMark(int.Parse(Console.ReadLine()));
        }
    }
}