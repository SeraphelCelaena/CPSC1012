using System;
using System.Transactions;

struct Student
{
    public int studentID;
    public string studentName;
    public int studentAge;
    public string studentEmail;
};

class Program
{
    public static void PrintRecord(Student st)
    {
        Console.WriteLine($"Student ID = {st.studentID}");
        Console.WriteLine($"Student Name = {st.studentName}");
        Console.WriteLine($"Student Age = {st.studentAge}");
        Console.WriteLine($"Student Email = {st.studentEmail}");
    }

    public static Student CreateValues()
    {
        Student ST;

        ST.studentID = 123;
        ST.studentName = "Cookie";
        ST.studentAge = 18;
        ST.studentEmail = "Cookie@nait.ca";

        return ST;
    }

    public static void Main(string[] args)
    {
        Student ST; 

        ST = CreateValues();

        PrintRecord(ST);
    }
}