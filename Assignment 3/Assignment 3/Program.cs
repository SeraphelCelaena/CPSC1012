/*
Purpose: Assignment 3: Craps and Pig
Inputs: Casino Game Inputs
Outputs: Casino Game
Written By: Andrew Ng
Written For: Harsimranjot Singh Aulakh
Section: A06
Last Modified Date: November 21, 2022
Test Plan: Included in Provided Word Document
 */

using System;

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

    static int MainMenu()
    {
        string userInput;
        int output;

        Console.WriteLine();
        Console.WriteLine("|------------------|");
        Console.WriteLine("| CPSC1012 Casino  |");
        Console.WriteLine("|------------------|");
        Console.WriteLine("| 1. Play Craps    |");
        Console.WriteLine("| 2. Play Pig      |");
        Console.WriteLine("| 0. Exit Program  |");
        Console.WriteLine("|------------------|");

        do
        {
            Console.Write("Enter Menu Number: ");
            userInput = Console.ReadLine();
            Console.WriteLine();

            switch (userInput)
            {
                case "0" or "1" or "2":
                    output = int.Parse(userInput);
                    return output;
                    break;
                default:
                    Console.WriteLine($"{userInput} is not a Valid Menu Choice. Try Again.");
                    break;
            }
        } while (true);
    }

    static int D6()
    {
        Random Dice = new Random();

        return Dice.Next(1, 7);
    }

    static bool PlayAgain()
    {
        string userInput;

        userInput = PromptString("Do you want to play again (y/n): ");

        while (true)
        {
            switch (userInput)
            {
                case "y" or "Y":
                    return true;
                    break;

                case "n" or "N":
                    return false;
                    break;

                default:
                    Console.WriteLine();
                    Console.WriteLine($"{userInput} is not a Valid Input.");
                    userInput = PromptString("Play Again (y/n): ");
                    break;
            }
        }
    }

    static bool RollOrHold()
    {
        string userInput;

        userInput = PromptString("Roll or Hold (r/h): ");

        while (true)
        {
            switch (userInput)
            {
                case "r" or "R":
                    return true;
                    break;

                case "h" or "H":
                    return false;
                    break;

                default:
                    Console.WriteLine();
                    Console.WriteLine($"{userInput} is not a Valid Input.");
                    userInput = PromptString("Roll or Hold (r/h): ");
                    break;
            }
        }
    }

    static void Craps()
    {
        bool gameLoop;
        bool pointLoop;

        int bet;
        int roll1;
        int roll2;
        int rollResult;
        
        int point;

        int money = 0;

        Console.WriteLine("-----------------");
        Console.WriteLine("| Game of Craps |");
        Console.WriteLine("-----------------");

        do
        {
            Console.WriteLine();
            bet = PromptInt("Enter Bet Amount: ");

            roll1 = D6();
            roll2 = D6();
            rollResult = roll1 + roll2;

            Console.WriteLine($"You Rolled {roll1} + {roll2} = {rollResult}");

            switch (rollResult)
            {
                case 2 or 3 or 12:
                    Console.WriteLine($"You Lost {bet.ToString("C")}");
                    money -= bet;
                    break;

                case 7 or 11:
                    Console.WriteLine($"You Win {bet.ToString("C")}");
                    money += bet;
                    break;

                default:
                    pointLoop = true;
                    point = rollResult;
                    Console.WriteLine($"Point is {point}");

                    do
                    {
                        roll1 = D6();
                        roll2 = D6();
                        rollResult = roll1 + roll2;

                        Console.WriteLine($"You Rolled {roll1} + {roll2} = {rollResult}");

                        if (rollResult == point)
                        {
                            Console.WriteLine($"You Win {bet.ToString("C")}");
                            money += bet;
                            pointLoop = false;
                        }
                        else if (rollResult == 7)
                        {
                            Console.WriteLine($"You Lost {bet.ToString("C")}");
                            money -= bet;
                            pointLoop = false;
                        }
                    } while (pointLoop == true);
                    break;
            }

            gameLoop = PlayAgain();

            if (gameLoop == false)
            {
                if (money >= 0)
                {
                    Console.WriteLine($"Your net winning is {money.ToString("C")}");
                }
                else
                {
                    Console.WriteLine($"Your net loss is {Math.Abs(money).ToString("C")}");
                }
            }

        } while (gameLoop == true);
    }

    static int PlayerTurn(int playerScore, int computerScore)
    {
        bool rollHold;
        int points = 0;
        int roll;

        Console.WriteLine();
        Console.WriteLine("It's your turn.");

        do
        {
            roll = D6();

            if (roll == 1)
            {
                Console.WriteLine($"You rolled a {roll}");
                Console.WriteLine("Your Turn Score is 0");
                Console.WriteLine();
                Console.WriteLine($"Your Total Points: {playerScore}");
                Console.WriteLine($"Computer Total Points: {computerScore}");
                return playerScore;
            }
            else
            {
                Console.WriteLine($"You rolled a {roll}");
                points += roll;
            }

            if (roll != 1)
            {
                rollHold = RollOrHold();

                if (rollHold == false)
                {
                    Console.WriteLine("You HOLD");
                    Console.WriteLine($"Your Turn Total Score is {points}");

                    playerScore += points;

                    Console.WriteLine();
                    Console.WriteLine($"Your Total Points: {playerScore}");
                    Console.WriteLine($"Computer Total Points: {computerScore}");
                    return playerScore;
                }
            }
        } while (true);
    }

    static int ComputerTurn(int playerScore, int computerScore)
    {
        int roll;
        int points = 0;

        Console.WriteLine();
        Console.WriteLine("It's the Computer's Turn.");

        while (true)
        {
            roll = D6();

            Console.WriteLine($"Computer rolled a {roll}");
            points += roll;

            if (roll == 1)
            {
                Console.WriteLine($"Computer Turn Total is 0");
                Console.WriteLine();
                Console.WriteLine($"Your Total Points: {playerScore}");
                Console.WriteLine($"Computer Total Points: {computerScore}");

                return computerScore;
            }

            if (points >= 10)
            {
                computerScore += points;
                Console.WriteLine($"Computer Turn Total is {points}");
                Console.WriteLine();
                Console.WriteLine($"Your Total Points: {playerScore}");
                Console.WriteLine($"Computer Total Points: {computerScore}");
                
                return computerScore;
            }
        }
    }


    static void Pig()
    {
        bool gameLoop;
        int pointGoal = 0;
        bool gameSession;

        int playerScore;
        int computerScore;

        Console.WriteLine("---------------");
        Console.WriteLine("| Game of Pig |");
        Console.WriteLine("---------------");

        do
        {
            pointGoal = PromptInt("Enter the Point Total to Play For: ");
            gameSession = true;

            playerScore = 0;
            computerScore = 0;
            do
            {
                if (playerScore <= pointGoal || computerScore <= pointGoal)
                {
                    playerScore = PlayerTurn(playerScore, computerScore);

                    if (playerScore >= pointGoal)
                    {
                        Console.WriteLine("You WIN!");
                        gameSession = false;
                    }
                }

                if ((playerScore <= pointGoal || computerScore <= pointGoal) && gameSession == true)
                {
                    computerScore = ComputerTurn(playerScore, computerScore);

                    if (computerScore >= pointGoal)
                    {
                        Console.WriteLine("You LOSE!");
                        gameSession = false;
                    }
                }

            } while (gameSession == true);

            gameLoop = PlayAgain();

            if (gameLoop == true)
            {
                gameSession = false;
            }

        } while (gameLoop == true);
    }

    public static void Main(string[] args)
    {
        bool loopMain = true;
        int mainMenuInput;

        while (loopMain == true)
        {
            mainMenuInput = MainMenu();

            switch (mainMenuInput)
            {
                case 0:
                    loopMain = false;
                    Console.WriteLine("Good-bye and Thank You for Playing the CPSC1012 Casino.");
                    break;

                case 1:
                    Craps();
                    break;

                case 2:
                    Pig();
                    break;
            }
        }
    }
}