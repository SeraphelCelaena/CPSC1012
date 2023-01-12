using System;
using System.Runtime.Intrinsics.X86;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine((16 + 8) / 4 - 3 * 2);
        /*
        int mark;
        bool honors;

        
        if (mark >= 80)
        {
            honors = true;
        }
        else
        {
            honors = false;
        }
        

        string unicornName;
        Console.Write("What is the name of your unicorn? ");
        unicornName = Console.ReadLine();

        Console.Write(1 / 3 + 2 / 3);

        int hitPoints;
        int healerLevel = 2;

        switch (healerLevel)
        {
            case 1:
                hitPoints = 500;
                break;
            case 2:
                hitPoints = 600;
                break;
            case 3:
                hitPoints = 840;
                break;
            default:
                hitPoints = 1176;
                break;
        }
        

        string sponsor = "SheRa";
        double amount = 4272.00;

        Console.WriteLine($"{sponsor} donated {amount.ToString("C")}");
        

        int playerPosition = 0;
        int computerPosition = 0;
        int endPosition = 0;
        int playerWins = 0;

        if (playerPosition >= endPosition && computerPosition < endPosition)
        {
            playerWins++;
        }

        for (int count = 0; count <= 5; count++)
        {
            Console.WriteLine($"{count,-5} {count * count}");
        }
        

        char playAgain;

        do
        {
            Console.Write("Do you want to play again (y/n): ");
            playAgain = Console.ReadLine().ToChar();

            if (playAgain != 'y' && playAgain != 'n')
            {
                Console.WriteLine("Invalid Input. Enter y or n");
            }
        } while (playAgain != 'y' || playAgain != 'n');
        

        double fahrenheit;
        int conversions;

        Console.WriteLine("This program prints a Fahrenheit to Celsius conversion table");
        Console.Write("Enter starting Fahrenheit temperature: ");
        fahrenheit = double.Parse(Console.ReadLine());

        Console.Write("Enter the number of conversions to see: ");
        conversions = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine($"{"Fahrenheit",10} {"Celsius",-10}");

        // In the answer field enter ONLY the missing code to print the Fahrenheit to Celsius conversion table in increments of one degree.
        double celsius;

        for (int i = 0; i < conversions; i++)
        {
            celsius = (5.0 / 9.0) * fahrenheit - 32;

            Console.WriteLine("{0} {1:0.0}", fahrenheit.ToString().PadLeft(10), celsius);
            fahrenheit++;
        }
        

        int playerPosition;
        int computerPosition;
        int endPosition;
        bool gameOver;

        if (playerPosition >= endPosition || computerPosition >= endPosition)
        {
            gameOver = true;
        }
        

        int creditHours = 0; // semester credit hours passed and transferred          
        string studentClassification;

        Console.Write("Enter the number of semester credit hours completed: ");
        // In the answer field enter ONLY the missing code

        creditHours = int.Parse(Console.ReadLine());

        if (creditHours < 30)
        {
            studentClassification = "freshman";
        }
        else if (creditHours < 60)
        {
            studentClassification = "sophomore";
        }
        else if (creditHours < 90)
        {
            studentClassification = "junior";
        }
        else if (creditHours >= 90)
        {
            studentClassification = "senior";
        }

        Console.WriteLine($"You are classified as a {studentClassification} student");
        

        string province;
        double pst;

        if (province == "BC")
        {
            pst = 0.07;
        }
        

        const double GstRate = 0.05;


        double amount;
        string inputValue = Console.ReadLine();
        amount = double.Parse(inputValue);
        

        int age = int.Parse(Console.ReadLine());
        int maxHours;

        if (age < 18)
        {
            maxHours = 8;
        }
        else if (age < 65)
        {
            maxHours = 12;
        }
        else  if (age >= 65)
        {
            maxHours = 5;
        }
        */

        Random rand = new Random();
        int computerNumber = rand.Next(1, 11);
        int playerGuess;
        int guessAttempts = 0;

        Console.WriteLine("The computer generated a random number between 1 and 10.");
        // Enter in the answer field ONLY the missing code

        do
        {
            Console.Write("Enter your guess (of range to stop): ");
            playerGuess = int.Parse(Console.ReadLine());

            if (playerGuess < 1 || playerGuess > 10)
            {
                Console.WriteLine("You did not guess correct number. ");
                break;
            }
            else if (playerGuess != computerNumber)
            {
                guessAttempts++;
                Console.WriteLine($"{playerGuess} is incorrect");
            }
            else
            {
                guessAttempts++;
                Console.WriteLine($"You Guessed the Correct Number in {guessAttempts} attempts.");
            }

        } while (playerGuess != computerNumber);

    }
}