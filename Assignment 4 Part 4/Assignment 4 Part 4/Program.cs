/*
Purpose:  Assignment 4 Part 4
Input: room length and width and carpet cost per square foot
Output: total room carpet cost
Written by: Andrew Ng
Written for: Harsimranjot Singh Aulakh
Section: A06
Last Modified Date: December 13, 2022
*/

class RoomDimension
{
    double _length; // Fields or Data Member
    double _width;

    // Accessor Methods and Mutator Methods
    public double Length 
    {
        get
        {
            return _length;
        }

        set
        {
            if (value < 0)
            {
                throw new Exception("Cannot Have Negative Value");
            }
            else
            {
                _length = value;
            }
        }
    }

    public double Width
    {
        get
        {
            return _width;
        }

        set
        {
            if (value < 0)
            {
                throw new Exception("Cannot Have Negative Value");
            }
            else
            {
                _width = value;
            }
        }
    }

    // Constructor
    public RoomDimension(double length, double width)
    {
        Length = length;
        Width = width;
    }

    // Methods
    public double Area()
    {
        return Length * Width;
    }

    public override string ToString()
    {
        return $"Length = {Length}, Width = {Width}";
    }
}

class RoomCarpet
{
    // Fields
    RoomDimension _size;
    double _carpetCost;

    // Accessor Methods and Mutator Methods
    public RoomDimension Size
    {
        get
        {
            return _size;
        }

        set
        {
            _size = value;
        }
    }

    public double CarpetCost
    {
        get
        {
            return _carpetCost;
        }

        set
        {
            if (value < 0)
            {
                throw new Exception("Cannot Have Negative Value");
            }
            else
            {
                _carpetCost = value;
            }
        }
    }

    // Constructor
    public RoomCarpet(RoomDimension dimen, double cost)
    {
        Size = dimen;
        CarpetCost = cost;
    }

    // Methods
    public double TotalCost()
    {
        return Size.Area() * CarpetCost;
    }

    public override string ToString()
    {
        return $"Area = {Size.Area()}, Cost = {TotalCost().ToString("C")}";
    }
}

class Program
{
    static string PromptString(string label)
    {
        string userInput;

        Console.Write(label);
        userInput = Console.ReadLine();

        return userInput;
    }

    static double PromptDouble(string label)
    {
        double userInput;

        while (true)
        {
            try
            {
                userInput = double.Parse(PromptString(label));
                return userInput;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }

    public static void Main(string[] args)
    {
        // Declaring Variables
        double roomLength;
        double roomWidth;
        double carpetCost;

        RoomDimension room;
        RoomCarpet roomCost;

        // Main Menu Title
        Console.WriteLine("*********************");
        Console.WriteLine("* Carpet Calculator *");
        Console.WriteLine("*********************");
        Console.WriteLine();

        // User Input
        roomLength = PromptDouble("Enter the Room Length in Feet: ");
        roomWidth = PromptDouble("Enter the Room Width in Feet: ");
        carpetCost = PromptDouble("Enter the Carpet Cost per Square Foot: ");
        Console.WriteLine();

        // Calculations
        room = new RoomDimension(roomLength, roomWidth);
        roomCost = new RoomCarpet(room, carpetCost);

        // Display
        Console.WriteLine(room.ToString());
        Console.WriteLine(roomCost.ToString());
    }
}