/*
Purpose:  Lab 6
Input: 
Output: 
Written by: Andrew Ng
Written for: Harsimranjot Singh Aulakh
Section: A06
Last Modified Date: December 10, 2022
*/

using System;
using System.Transactions;

class MultipleChoiceQuestion
{
    string question;
    string choice1;
    string choice2;
    string choice3;
    string choice4;
    string answer;

    public string Question
    {
        get
        {
            return question;
        }

        set
        {
            question = value;
        }
    }

    public string Choice1
    {
        get
        {
            return choice1;
        }

        set
        {
            choice1 = value;
        }
    }

    public string Choice2
    {
        get
        {
            return choice2;
        }

        set
        {
            choice2 = value;
        }
    }

    public string Choice3
    {
        get
        {
            return choice3;
        }

        set
        {
            choice3 = value;
        }
    }

    public string Choice4
    {
        get
        {
            return choice4;
        }

        set
        {
            choice4 = value;
        }
    }

    public string Answer
    {
        get
        {
            return answer;
        }

        set
        {
            answer = value;
        }
    }

    public MultipleChoiceQuestion(string question, string choice1, string choice2, string choice3, string choice4, string answer)
    {
        Question = question;
        Choice1 = choice1;
        Choice2 = choice2;
        Choice3 = choice3;
        Choice4 = choice4;
        Answer = answer;
    }

    public MultipleChoiceQuestion()
    {

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

    static int Menu()
    {
        int userInput;

        Console.WriteLine("---------------------------------------");
        Console.WriteLine("| Multiple-Choice Quiz Administration |");
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("\t1. List Multiple Choice Questions");
        Console.WriteLine("\t2. Add Multiple Choice Question");
        Console.WriteLine("\t3. Delete Multiple Choice Question");
        Console.WriteLine("\t4. Quit");
        Console.WriteLine();

        userInput = PromptInt("Enter Menu Option: ");
        Console.WriteLine();

        return userInput;
    }

    static void ListQuestions(List<MultipleChoiceQuestion> multipleChoiceQuestions)
    {
        if (multipleChoiceQuestions.Count == 0)
        {
            Console.WriteLine("There are currently no items in the database.");
            Console.WriteLine();
        }
        else
        {
            for (int i = 0; i < multipleChoiceQuestions.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {multipleChoiceQuestions[i].Question}");
                Console.WriteLine($"\t1. {multipleChoiceQuestions[i].Choice1}");
                Console.WriteLine($"\t2. {multipleChoiceQuestions[i].Choice2}");
                Console.WriteLine($"\t3. {multipleChoiceQuestions[i].Choice3}");
                Console.WriteLine($"\t4. {multipleChoiceQuestions[i].Choice4}");
                Console.WriteLine($"Current Answer: {multipleChoiceQuestions[i].Answer}");
                Console.WriteLine();
            }
        }
    }

    static List<MultipleChoiceQuestion> LoadQuestionsFromFile(string filePath)
    {
        List<MultipleChoiceQuestion> multipleChoiceQuestionsList = new List<MultipleChoiceQuestion>();
        string readerLine;
        string[] readerSplit;

        try
        {
            StreamReader reader = new StreamReader(filePath);

            while (reader.EndOfStream == false)
            {
                readerLine = reader.ReadLine();
                readerSplit = readerLine.Split(", ");
                multipleChoiceQuestionsList.Add(new MultipleChoiceQuestion(readerSplit[0], readerSplit[1], readerSplit[2], readerSplit[3], readerSplit[4], readerSplit[5]));
            }

            reader.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error While Reading File: {e.Message}");
        }

        return multipleChoiceQuestionsList;
    }

    static List<MultipleChoiceQuestion> AddQuestion(List<MultipleChoiceQuestion> multipleChoiceQuestions)
    {
        string question;
        string choice1;
        string choice2;
        string choice3;
        string choice4;
        string answer;

        question = PromptString("Enter the Multiple Choice Question Text: ");
        choice1 = PromptString("Enter Answer #1: ");
        choice2 = PromptString("Enter Answer #2: ");
        choice3 = PromptString("Enter Answer #3: ");
        choice4 = PromptString("Enter Answer #4: ");
        answer = PromptString("Enter Correct Answer (1-4): ");
        Console.WriteLine();

        multipleChoiceQuestions.Add(new MultipleChoiceQuestion(question, choice1, choice2, choice3, choice4, answer));

        return multipleChoiceQuestions;
    }

    static List<MultipleChoiceQuestion> DeleteQuestion(List<MultipleChoiceQuestion> multipleChoiceQuestions)
    {
        int userInput;
        
        Console.WriteLine("Item Number     Question");
        Console.WriteLine("-----------     -------------------------------------------------------");

        for (int i = 0; i < multipleChoiceQuestions.Count; i++)
        {
            Console.WriteLine($"{(i + 1).ToString().PadLeft(11)}     {multipleChoiceQuestions[i].Question}");
        }
        Console.WriteLine();

        userInput = PromptInt("Select Item to Delete: ");

        multipleChoiceQuestions.RemoveAt(userInput - 1);

        return multipleChoiceQuestions;
    }

    static void SaveQuestions(List<MultipleChoiceQuestion> multipleChoiceQuestions, string path)
    {
        try
        {
            StreamWriter writer = new StreamWriter(path);

            for (int i = 0; i < multipleChoiceQuestions.Count; i++)
            {
                string toWrite = "";

                toWrite += multipleChoiceQuestions[i].Question;
                toWrite += multipleChoiceQuestions[i].Choice1;
                toWrite += multipleChoiceQuestions[i].Choice2;
                toWrite += multipleChoiceQuestions[i].Choice3;
                toWrite += multipleChoiceQuestions[i].Choice4;
                toWrite += multipleChoiceQuestions[i].Answer;

                writer.WriteLine(toWrite);
            }

            writer.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error While Writing to File: {e.Message}");
        }
    }

    public static void Main(string[] args)
    {
        int menuInput;
        string filePath = "G:\\Programming\\Lab4-ListsAndFiles\\Lab4-ListsAndFiles\\QuizQuestions.txt";

        List<MultipleChoiceQuestion> multipleChoiceQuestionsList = LoadQuestionsFromFile(filePath);

        do
        {
            menuInput = Menu();

            switch (menuInput)
            {
                case 1:
                    ListQuestions(multipleChoiceQuestionsList);
                    break;

                case 2:
                    multipleChoiceQuestionsList = AddQuestion(multipleChoiceQuestionsList);
                    break;

                case 3:
                    multipleChoiceQuestionsList = DeleteQuestion(multipleChoiceQuestionsList);
                    break;

                case 4:
                    SaveQuestions(multipleChoiceQuestionsList, filePath);
                    break;
            }
        } while (menuInput != 4);
    }
}