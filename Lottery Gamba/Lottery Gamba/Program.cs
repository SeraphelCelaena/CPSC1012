/*
Purpose: Assignment 3: Lottery Tickets
Inputs: Lottery Inputs
Outputs: Lotto Rewards
Written By: Andrew Ng
Written For: Harsimranjot Singh Aulakh
Section: A06
Last Modified Date: November 29, 2022
Test Plan: Included in Provided Word Document
 */

using System;
using System.Diagnostics;

class Program
{
    static string PromptString(string label)
    {
        string userInput;

        Console.Write(label);
        userInput = Console.ReadLine();

        return userInput;
    }

    static int PromptInt(string label)
    {
        int userInput;

        while (true)
        {
            try
            {
                userInput = int.Parse(PromptString(label));
                return userInput;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }

    static int PromptLottoInput(string label, int size, int maxNumber, int[] lotto)
    {
        int userInput;

        while (true)
        {
            userInput = PromptInt(label);

            if (userInput > maxNumber || userInput < 1)
            {
                Console.WriteLine($"Enter a number between 1 and {maxNumber}");
            }
            else if (lotto.Contains(userInput))
            {
                Console.WriteLine("Cannot insert a value already there");
            }
            else
            {
                return userInput;
            }
        }
    }

    static int MainMenu()
    {
        string userInput;

        Console.WriteLine();
        Console.WriteLine("|------------------------------------------------|");
        Console.WriteLine("| CPSC1012 Lotto Centre                          |");
        Console.WriteLine("|------------------------------------------------|");
        Console.WriteLine("| 1. Change Lotto MAX winning numbers            |");
        Console.WriteLine("| 2. Change Lotto 6/49 winning numbers           |");
        Console.WriteLine("| 3. Change Lotto EXTRA winning numbers          |");
        Console.WriteLine("| 4. Play Lotto MAX                              |");
        Console.WriteLine("| 5. Play Lotto 6/49                             |");
        Console.WriteLine("| 0. Exit Program                                |");
        Console.WriteLine("|------------------------------------------------|");

        while (true)
        {
            Console.WriteLine();
            userInput = PromptString("Enter Menu Choice: ");

            switch (userInput)
            {
                case "1" or "2" or "3" or "4" or "5" or "0":
                    return int.Parse(userInput);
                    break;

                default:
                    Console.WriteLine($"{userInput} is not a Valid Menu Choice. Try Again.");
                    break;
            }
        }
    }

    static int[] SortLotteryNumbers(int[] lottery)
    {
        int temp;

        for (int i = 0; i < lottery.Length - 1; i++)
        {
            for (int j = 0; j < lottery.Length - 2; j++)
            {
                if (lottery[j] > lottery[j+1])
                {
                    temp = lottery[j];
                    lottery[j] = lottery[j + 1];
                    lottery[j + 1] = temp;
                }
            }
        }

        return lottery;
    }

    static int[] GenerateLottery(int size, int maxNumber)
    {
        int[] lottery = new int[size];
        Random random = new Random();
        int bonus = random.Next(size);
        int temp;
        int loopIndex = 0;
        bool loop = true;


        while (loop == true)
        {
            temp = random.Next(1, maxNumber);

            if (lottery.Contains(temp))
            { }
            else
            {
                lottery[loopIndex] = temp;
                loopIndex++;
            }

            if (loopIndex == size)
            {
                loop = false;
            }
        }

        temp = lottery[size - 1];
        lottery[size - 1] = lottery[bonus];
        lottery[bonus] = temp;
        lottery = SortLotteryNumbers(lottery);

        return lottery;
    }

    static int[] EnterLottery(int size, int maxNumber)
    {
        int userInput;
        int[] userArray = new int[size];

        for (int i = 0; i < size; i++)
        {
            if (i != size - 1)
            {
                userInput = PromptLottoInput($"Enter Number #{i + 1}: ", size, maxNumber, userArray);
            }
            else
            {
                userInput = PromptLottoInput($"Enter Bonus Number: ", size, maxNumber, userArray);
            }

            userArray[i] = userInput;
        }

        userArray = SortLotteryNumbers(userArray);
        return userArray;
    }

    static int[] ChangeLotto(int[] lottery, int size, int maxNumber, string lottoName)
    {
        string userInput;
        bool loop;

        Console.Write($"The Current Winning {lottoName} Numbers are: ");

        for (int i = 0; i < size - 1; i++)
        {
            if (i != size - 2)
            {
                Console.Write($"{lottery[i]}, ");
            }
            else
            {
                Console.Write(lottery[i]);
            }
        }
        Console.Write($"( Bonus: {lottery[size - 1]})\n");

        do
        {
            userInput = PromptString("Would you like to generate or enter the winning numbers (g/e): ");
            
            switch (userInput)
            {
                case "e" or "E" or "g" or "G":
                    loop = false;
                    break;
                default:
                    Console.WriteLine($"{userInput} is a Invalid Input");
                    loop = true;
                    break;
            }
        } while (loop == true);

        switch (userInput)
        {
            case "e" or "E":
                lottery = EnterLottery(size, maxNumber);
                break;

            case "g" or "G":
                lottery = GenerateLottery(size, maxNumber);
                break;
        }

        Console.Write($"The New Winning {lottoName} Numbers are: ");

        for (int i = 0; i < size - 1; i++)
        {
            if (i != size - 2)
            {
                Console.Write($"{lottery[i]}, ");
            }
            else
            {
                Console.Write(lottery[i]);
            }
        }
        Console.Write($"( Bonus: {lottery[size - 1]})\n");

        return lottery;
    }

    static int ChangeExtra(int lotto)
    {
        Random random = new Random();

        Console.WriteLine($"The Current Lotto Extra Number is: {lotto}");

        int lottoExtra = random.Next(9999999);
        Console.WriteLine($"The New Lotto Extra Number is: {lottoExtra}");

        return lottoExtra;
    }

    static void LottoMaxPrize(int match, bool bonus)
    {
        Console.Write("Your Lotto Max Prize: ");

        if (match == 7)
        {
            Console.WriteLine("Win or share Jackpot of at least $10 Million or 87.25% of Pools Fund");
        }
        else if (match == 6)
        {
            Console.WriteLine("Share of 2.5% of Pools Fund");
        }
        else if (match == 5 && bonus == true)
        {
            Console.WriteLine("Share of 1.5% of Pools Fund");
        }
        else if (match == 5)
        {
            Console.WriteLine("Share of 3.5% of Pools Fund");
        }
        else if (match == 4 && bonus == true)
        {
            Console.WriteLine("Share of 2.75% of Pools Fund");
        }
        else if (match == 4)
        {
            Console.WriteLine("$20");
        }
        else if (match == 3 && bonus == true)
        {
            Console.WriteLine("$20");
        }
        else if (match == 3)
        {
            Console.WriteLine("Free Play");
        }
        else
        {
            Console.WriteLine("$0");
        }
    }

    static void Lotto649Prize(int match, bool bonus)
    {
        Console.Write("Your Lotto 649 Prize: ");

        if (match == 6)
        {
            Console.WriteLine("Win or share Jackpot (79.5% of the Pools Fund)");
        }
        else if (match == 5 && bonus == true)
        {
            Console.WriteLine("Share of 6% of Pools Fund");
        }
        else if (match == 5)
        {
            Console.WriteLine("Share of 4% of Pools Fund");
        }
        else if (match == 4)
        {
            Console.WriteLine("Share of 9.5% of Pools Fund");
        }
        else if (match == 3)
        {
            Console.WriteLine("$10");
        }
        else if (match == 2 && bonus == true)
        {
            Console.WriteLine("$5");
        }
        else if (match == 2)
        {
            Console.WriteLine("Free Play");
        }
        else
        {
            Console.WriteLine("$0");
        }
    }

    static void LottoExtraPrize(int lottoExtra, int lottoExQuick)
    {
        int match = 0;
        string lottoEx = lottoExtra.ToString();
        string lottoExQ = lottoExQuick.ToString();

        for (int i = lottoExtra.ToString().Length - 1; i > 0; i--)
        {
            if (lottoEx[i] == lottoExQ[i])
            {
                match++;
            }
        }

        Console.WriteLine($"Your Lotto Extra Match: Last {match} digits");
        Console.Write("Your Lotto Extra Prize: ");

        switch (match)
        {
            case 7:
                Console.WriteLine("$250,000");
                break;

            case 6:
                Console.WriteLine("$100,000");
                break;

            case 5:
                Console.WriteLine("$1,000");
                break;

            case 4:
                Console.WriteLine("$100");
                break;

            case 3:
                Console.WriteLine("$50");
                break;

            case 2:
                Console.WriteLine("$10");
                break;

            case 1:
                Console.WriteLine("$2");
                break;

            default:
                Console.WriteLine("$0");
                break;
        }
    }

    static void GetMatch(int[] lottery, int[] lottoQuick, int lottoExtra, int lottoExQuick, string lottoName)
    {
        int match = 0;
        bool bonus = false;

        for (int i = 0; i < lottery.Length; i++)
        {
            for (int j = 0; j < lottoQuick.Length; j++)
            {
                if (lottery[i] == lottoQuick[j] && i == lottery.Length)
                {
                    bonus = true;
                }
                else if (lottery[i] == lottoQuick[j])
                {
                    match++;
                }
            }
        }

        Console.WriteLine($"Your {lottoName} Match: {match}/{lottery.Length-1}");

        switch (lottoName)
        {
            case "Lotto Max":
                LottoMaxPrize(match, bonus);
                break;

            case "Lotto 649":
                Lotto649Prize(match, bonus);
                break;
        }

        LottoExtraPrize(lottoExtra, lottoExQuick);
    }

    static void PlayLotto(int[] lottery, int lottoExtra, int size, int maxNumber, string lottoName)
    {
        Random random = new Random();
        int[] lottoQuick = new int[size];
        int lottoExQuick = random.Next(1000000, 9999999);
        bool loop = true;
        int temp;
        int loopIndex = 0;

        Console.Write($"The Current Winning {lottoName} Numbers are: ");

        for (int i = 0; i < size - 1; i++)
        {
            if (i != size - 2)
            {
                Console.Write($"{lottery[i]}, ");
            }
            else
            {
                Console.Write(lottery[i]);
            }
        }
        Console.Write($"( Bonus: {lottery[size - 1]})\n");

        Console.WriteLine($"The Current Lotto EXTRA Number is: {lottoExtra}");
        Console.WriteLine();

        while (loop == true)
        {
            temp = random.Next(1, maxNumber);

            if (lottoQuick.Contains(temp))
            { }
            else
            {
                lottoQuick[loopIndex] = temp;
                loopIndex++;
            }

            if (loopIndex == size)
            {
                loop = false;
            }
        }

        Console.Write($"Your Lotto Quickpick Numbers Numbers are: ");

        for (int i = 0; i < size - 1; i++)
        {
            if (i != size - 2)
            {
                Console.Write($"{lottoQuick[i]}, ");
            }
            else
            {
                Console.Write(lottoQuick[i]);
            }
        }
        Console.Write($"( Bonus: {lottoQuick[size - 1]})\n");

        Console.WriteLine($"Your Lotto EXTRA Number is: {lottoExQuick}");
        Console.WriteLine();

        GetMatch(lottery, lottoQuick, lottoExtra, lottoExQuick, lottoName);
    }

    public static void Main(string[] args)
    {
        Random random = new Random();

        const int LottoMaxSize = 8;
        const int LottoMaxMaxNumber = 50;
        int[] lottoMax = GenerateLottery(LottoMaxSize, LottoMaxMaxNumber);

        const int Lotto649Size = 7;
        const int Lotto649MaxNumber = 49;
        int[] lotto649 = GenerateLottery(Lotto649Size, Lotto649MaxNumber);
        int lottoExtra = random.Next(1000000, 9999999);

        bool mainLoop = true;
        int menuInput;

        while (mainLoop == true)
        {
            menuInput = MainMenu();

            switch (menuInput)
            {
                case 0:
                    Console.WriteLine("Good-bye and thanks for coming to the CPSC1012 Lotto Centre.");
                    mainLoop = false;
                    break;

                case 1:
                    lottoMax = ChangeLotto(lottoMax, LottoMaxSize, LottoMaxMaxNumber, "Lotto Max");
                    break;

                case 2:
                    lotto649 = ChangeLotto(lotto649, Lotto649Size, Lotto649MaxNumber, "Lotto 649");
                    break;

                case 3:
                    lottoExtra = ChangeExtra(lottoExtra);
                    break;

                case 4:
                    PlayLotto(lottoMax, lottoExtra, LottoMaxSize, LottoMaxMaxNumber, "Lotto Max");
                    break;

                case 5:
                    PlayLotto(lotto649, lottoExtra, Lotto649Size, Lotto649MaxNumber, "Lotto 649");
                    break;
            }
        }
    }
}