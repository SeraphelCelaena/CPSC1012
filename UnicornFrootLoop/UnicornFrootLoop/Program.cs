/*
Purpose: Assignment 2: Lööps
Inputs: Track Length, Sprites/Characters for both Player and Computer
Outputs: Unicorn Racing Game and Eventually Games Won/Lost/Tied
Written By: Andrew Ng
Written For: Harsimranjot Singh Aulakh
Section: A06
Last Modified Date: October 26, 2022
Test Plan: Included in Provided Word Document
 */

using System;

class Program
{
    public static string PromptString(string label) // Prompts user for String
    {
        // Declaring Variables
        string userInput;

        // Getting user Input
        Console.Write(label);
        userInput = Console.ReadLine();

        // Returning User Input
        return userInput;
    }

    public static int PromptInt(string label) // Prompts user for Integer
    {
        // Declaring Variables
        int userInput;

        // Getting user Input
        while (true)
        {
            try // Checking for Invalid Inputs
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

    public static string PromptChar(string label) // Prompts User for a Character
    {
        // Declaring Variables
        string userInput;

        // Getting user Input
        while (true) // Error checking
        {
            userInput = PromptString(label);
            
            if (userInput.Length == 1 && userInput != " ")
            {
                return userInput;
            }
            else
            {
                Console.WriteLine("Input Must be Exactly One Character Long");
            }
        }
    }

    public static string PromptSprite(string label) // Prompts User for a Character Sprite
    {
        string userInput;

        while (true)
        {
            userInput = PromptChar(label);

            if (userInput == " ") // Otherwise the play area can be filled with invisible unicorns (that sounds fun though)
            {
                Console.WriteLine("Enter a Character That is Not Space");
            }
            else
            {
                return userInput;
            }
        }
    }

    public static void DisplayTrack(int lengthTrack, string unicornPlayer, string UnicornComputer, int distancePlayer, int distanceComputer)
    {
        // Displays track number
        for (int i = 0; i <= lengthTrack; i++)
        {
            Console.Write(i%10);
        }
        Console.Write('\n');

        // Top of Track
        Console.Write(' ');
        for (int i = 1; i <= lengthTrack; i++)
        {
            Console.Write('=');
        }
        Console.Write('\n');

        // Unicorn Locations
        Console.WriteLine();
        Console.WriteLine(unicornPlayer.PadLeft(distancePlayer + 1));
        Console.WriteLine("\n");
        Console.WriteLine(UnicornComputer.PadLeft(distanceComputer + 1));
        Console.WriteLine();

        // Bottom of Track
        Console.Write(' ');
        for (int i = 1; i <= lengthTrack; i++)
        {
            Console.Write('=');
        }
        Console.WriteLine();
    }

    public static void DisplayRolls(int rollNumber, int rollPlayer, int rollComputer, int positionPlayer, int positionComputer)
    {
        // Display roll number
        Console.WriteLine($"Roll Number: {rollNumber}");
        Console.WriteLine();

        // Display roll Table
        Console.WriteLine("Roll".PadLeft(16) +  "Position".PadLeft(12));
        Console.WriteLine($"Player{rollPlayer.ToString().PadLeft(10)}{(positionPlayer).ToString().PadLeft(12)}");
        Console.WriteLine($"Computer{rollComputer.ToString().PadLeft(8)}{(positionComputer).ToString().PadLeft(12)}");
        Console.WriteLine();
    }

    public static void HitEnter()
    {
        // Just press enter
        Console.Write("Hit Enter to Roll");
        Console.ReadLine();
        Console.Clear();
    }

    static void Main(string[] args)
    {
        // Declaring Variables
        Random rand = new Random();

        bool loopMain = true;
        char exitInputLoop = 'Y';

        int lengthInput;
        string spritePlayer;
        string spriteComputer;

        bool gameLoop;

        int numRolls;
        int rollPlayer;
        int rollComputer;
        int positionPlayer;
        int positionComputer;

        int gamesWon = 0;
        int gamesLost = 0;
        int gamesTied = 0;

        // Welcome Message
        Console.WriteLine("Welcome to the Unicorn Racing Game!");
        Console.WriteLine();

        // Game Start
        while (exitInputLoop == 'y' || exitInputLoop == 'Y')
        {
            // Get Values From User
            do // Checking to see if track is greater than 6
            {
                lengthInput = PromptInt("Enter Track Length: ");

                if (lengthInput <= 6)
                {
                    Console.WriteLine("Invalid Value. Enter an Integer > 6");
                }
            } while (lengthInput <= 6);
            
            spritePlayer = PromptSprite("Enter Character Sprite for Player: ");
            spriteComputer = PromptSprite("Enter Character Sprite for Computer: ");
            Console.WriteLine();

            // Resets Variables
            numRolls = 0;
            positionPlayer = 0;
            positionComputer = 0;
            gameLoop = true;

            // Displays initial Track
            DisplayTrack(lengthInput, spritePlayer, spriteComputer, positionPlayer, positionComputer);
            HitEnter();

            // Play Game Loop
            while (gameLoop == true)
            {
                // Rolls values
                rollPlayer = rand.Next(1, 7);
                rollComputer = rand.Next(1, 7);
                numRolls++;

                // Adds values to current position
                positionPlayer += rollPlayer;
                positionComputer += rollComputer;

                // Displays Track and rolls
                DisplayTrack(lengthInput, spritePlayer, spriteComputer, positionPlayer, positionComputer);
                DisplayRolls(numRolls, rollPlayer, rollComputer, positionPlayer, positionComputer);

                // Checks to see if somebody won or if it is a tie
                if (positionPlayer > lengthInput && positionComputer > lengthInput) // If tie
                {
                    Console.WriteLine("It's a Tie!");
                    gamesTied++;
                    gameLoop = false;
                }
                else if (positionPlayer > lengthInput) // If no tie then that means we do not need to check for the other one because tie is the most niche case
                {
                    Console.WriteLine("You Win!");
                    gamesWon++;
                    gameLoop = false;
                }
                else if (positionComputer > lengthInput) // if both no tie or player win then check
                {
                    Console.WriteLine("Computer Wins!");
                    gamesLost++;
                    gameLoop = false;
                }
                else // If noone has won/tied yet, prompt user to continue
                {
                    HitEnter();
                }
            }

            
            // Exit or Play Again Loop
            do
            {
                try // catches exceptions to ensure proper inputs
                {
                    exitInputLoop = char.Parse(PromptChar("Play Again (Y/N): "));

                    switch (exitInputLoop) // Using switch because it is shorter than writing the equivalent if statement
                    {
                        case 'y' or 'Y' or 'n' or 'N':
                            loopMain = false;
                            break;
                        default:
                            Console.WriteLine("Invalid Input Value. Please Enter Y/N");
                            loopMain = true;
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid Input Value: " + e.Message);
                }
            } while (loopMain == true);
            Console.WriteLine();
            Console.Clear();
        }

        // End of Program Win Loss Tie Ratio
        Console.WriteLine($"You Won {gamesWon} Games.");
        Console.WriteLine($"You Lost {gamesLost} Games.");
        Console.WriteLine($"You Tied {gamesTied} Games.");
    }
}