using System;

class Program
{
    static double InputStartingBalance()
    {
        double userInput = -1;

        do
        {
            Console.Write("Enter Starting Balance: ");
            try
            {
                userInput = double.Parse(Console.ReadLine());

                if (userInput < 0)
                {
                    Console.WriteLine("Enter a Positive Number");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        } while (userInput < 0);

        return userInput;
    }

    static double InputAnnualInterestRate()
    {
        double userInput = -1;

        do
        {
            Console.Write("Enter Annual Interest Rate (5% as 0.05): ");
            try
            {
                userInput = double.Parse(Console.ReadLine());

                if (userInput < 0)
                {
                    Console.WriteLine("Enter a Positive Number");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        } while (userInput < 0);

        return userInput;
    }

    static int InputNumberOfYears()
    {
        int userInput = -1;

        do
        {
            Console.Write("Enter Years to Save: ");
            try
            {
                userInput = int.Parse(Console.ReadLine());

                if (userInput < 0)
                {
                    Console.WriteLine("Enter a Positive Number");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        } while (userInput < 0);

        return userInput;
    }

    static void CalculateValue(double balance, double interestRate, int years)
    {
        double monthly;
        double[] savings = new double[years+1];

        monthly = interestRate / 12;

        for (int i = 0; i <= years; i++)
        {
            savings[i] = balance;
            for (int j = 1; j <= 12; j++)
            {
                balance = balance + balance * monthly;
            }
        }

        for (int i = 0; i < savings.Length; i++)
        {
            Console.WriteLine($"Year {i}: {savings[i].ToString("C")}");
        }
    }

    public static void Main(string[] args)
    {
        double balance, interest;
        int years;

        balance = InputStartingBalance();
        interest = InputAnnualInterestRate();
        years = InputNumberOfYears();

        CalculateValue(balance, interest, years);
    }
}