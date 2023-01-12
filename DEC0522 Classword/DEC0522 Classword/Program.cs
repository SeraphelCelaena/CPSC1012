using System;

class Window
{
    double height;
    double width;

    public double Height
    {
        get { return height; }
        set 
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("value");
            }
            else
            {
                height = value;
            }
        }
    }

    public double Width
    {
        get { return width; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("value");
            }
            else
            {
                width = value;
            }
        }
    }

    public Window(double height, double width)
    {
        this.height = height;
        this.width = width;
    }

    public double CalculateArea()
    {
        return height * width;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        double windowHeight;
        double windowWidth;
        double windowArea;

        Console.WriteLine("Welcome to Window Area Calculator.");
        Console.Write("Enter the Width of Window: ");
        windowWidth = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the Height of Window: ");
        windowHeight = double.Parse(Console.ReadLine());

        // Creating Class
        Window win = new Window(windowHeight, windowWidth);

        windowArea = win.CalculateArea();

        Console.WriteLine($"Area of window is {windowArea}");
    }
}