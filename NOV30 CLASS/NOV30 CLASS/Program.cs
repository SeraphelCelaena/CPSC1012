using System;
using System.ComponentModel.Design.Serialization;
using System.Security.Principal;

class Student
{
    int studentID;
    string name;
    string email;
    double marks;

    
    public Student()
    {
        studentID = 0;
        name = "null";
        Console.WriteLine("Constructor/Initializer is called automatically");
    }
    
    public Student(int tempStudentID, string tempStudentName)
    {
        studentID = tempStudentID;
        name = tempStudentName;
    }

    public Student(int tempStudentID)
    {
        studentID = tempStudentID;
        name = "null";
    }

    public Student(string tempStudentName)
    {
        studentID = 0;
        name = tempStudentName;
    }

    public int GetStudentID()
    {
        return studentID;
    }

    public void SetStudentID(int input)
    {
        studentID = input;
    }

    public string GetStudentName()
    {
        return name;
    }

    public void SetStudentName(string input)
    {
        name = input;
    }

    public void DisplayStudentData()
    {
        Console.WriteLine($"StudentID = {studentID}");
        Console.WriteLine($"Student Name = {name}");
    }
}

class ClassStudent
{
    string firstName;
    string lastName;
    int studentID;

    public ClassStudent()
    {
        firstName = "null";
        lastName = "null";
        studentID = 0;
    }

    public ClassStudent(string firstName, string lastName, int studentID)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.studentID = studentID;
    }

    public string GetFirstName()
    {
        return firstName;
    }

    public string GetLastName()
    {
        return lastName;
    }

    public int GetStudentID()
    {
        return studentID;
    }

    public void SetFirstName(string firstName)
    {
        this.firstName = firstName;
    }

    public void SetLastName(string lastName)
    {
        this.lastName = lastName;
    }

    public void SetStudentID(int studentID)
    {
        this.studentID = studentID;
    }

    public string GetFullName()
    {
        return lastName + ", " + firstName;
    }
}

class Program
{
    public static void GetStudentInformation(ClassStudent[] st, int count)
    {
        for (int i = 0; i < count; i++)
        {
            Console.Write($"Enter StudentID for student {i + 1}");
            int tempID = int.Parse(Console.ReadLine());

            st[i] = st.
        }
    }

    public static void Main(string[] args)
    {
        Student st1 = new Student();
        Student st2 = new Student(1234, "QWER");
        int tempStudentID;
        string tempStudentName;

        Console.Write("Enter Student ID for First Student: ");
        tempStudentID = int.Parse(Console.ReadLine());
        st1.SetStudentID(tempStudentID);
        Console.WriteLine();

        Console.Write("Enter Student ID for First Student: ");
        tempStudentName = Console.ReadLine();
        st1.SetStudentName(tempStudentName);
        Console.WriteLine();
        
        st1.DisplayStudentData();
        st2.DisplayStudentData();



        int choice;
        const int ArraySize = 25;
        Student[] studentInfo = new Student[ArraySize];

        for (int i = 0; i < studentInfo.Length; i++)
        {
            studentInfo[i] = new Student();
        }

        do
        {
            Console.WriteLine("Menu Options");
            Console.WriteLine("Press 1 to Enter Student Information");
            Console.WriteLine("Press 2 to print Student Report");
            Console.WriteLine("press 3 to exit");
            Console.WriteLine("");

            Console.Write("Enter your Choice");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    break;

                case 2:
                    break;

                case 3:
                    break;

                default:
                    break;
            }
        }
    }
}