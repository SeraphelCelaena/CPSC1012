using System;

class Program
{
    /* ACCESSMODIFIER RETURNDATATYPE TYPE METHODNAME(DATATYPE NAME, DATATYPE NAME, ...)
    {
        
    }
    */

    public void DisplayData(int[] grade, double avg, string name, Student ob)
    {

    }

    public static void Main(string[] args)
    {
        //DATATYPE[] VARNAME = new DATATYPE[SIZE];
        int[] intMarks = new int[25]; // Array of size 25
        int[] intMarks2 = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

        string[] stringNames = { "Cookie", "Sbeve", "ASDF", "QWERTY" };

        char[] grades = { 'A', 'B', 'C', 'D' };

        intMarks2[2] = 77;

        int count = grades.Length;

        int[,] marks2D = new int[4, 5]; // 2D array
        int[,,] marks3D = new int[4, 5, 2]; // 3D array
    }
}