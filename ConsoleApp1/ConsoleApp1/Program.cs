/*
Author: Andrew Ng / Seraphel Celaena
*/

using System;
using System.Data.Common;
using System.Formats.Asn1;
using System.Runtime.InteropServices;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Random randValue = new Random();
        /*
        
        Console.WriteLine("Anything");
        Console.WriteLine("My Name is Andrew Ng, My age is 19, and i hope to have Infinite Money :D");
        Console.WriteLine();


        string name;
        int age;
        double annualPay;

        Console.WriteLine("Enter your name:");
        name = Console.ReadLine();

        Console.WriteLine("Enter your Age");
        age = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter your annual salary");
        annualPay = double.Parse(Console.ReadLine());

        Console.WriteLine("My Name is {0}, My age is {1}, and i hope to have an annual salary of ${2}", name, age, annualPay);
        Console.WriteLine($"My Name is {name}, My age is {age}, and i hope to have an annual salary of ${annualPay}");
        Console.WriteLine("My Name is " + name + ", My age is " + age + ", and i hope to have an annual salary of $" + annualPay);
        Console.WriteLine();


        double cylRadius, cylLength, cylArea, cylVolume;

        Console.WriteLine("Enter the radius and length of a cylinder: ");
        cylRadius = double.Parse(Console.ReadLine());
        cylLength = double.Parse(Console.ReadLine());

        cylArea = cylRadius * cylRadius * Math.PI;
        cylVolume = cylArea * cylLength;

        Console.WriteLine($"The area is {cylArea}");
        Console.WriteLine($"The volume is {cylVolume}");
        Console.WriteLine();
        

        double hexLength, hexArea;

        Console.WriteLine("Enter the Length of the side: ");
        hexLength = double.Parse(Console.ReadLine());

        hexArea = ((3 * Math.Sqrt(3)) / 2) * (Math.Pow(hexLength, 2));

        Console.WriteLine($"The area of the hexagon is {hexArea}");
        Console.WriteLine();


        int a = 10;
        int b = 5;
        int c = a + b;
        Console.WriteLine($"{a} + {b} = {c}");
        Console.WriteLine();


        int number, digitOne, digitTen, digitHundred, combined;

        Console.WriteLine("Enter a number between 0 and 1000: ");
        number = int.Parse(Console.ReadLine());

        digitOne = number % 10;
        digitTen = (number / 10) % 10;
        digitHundred = (number / 10) / 10;
        combined = digitHundred + digitTen + digitOne;

        Console.WriteLine($"The sum of the digits is {combined}");
        Console.WriteLine();


        double investmentAmount, investmentPercent, investmentMonthly, investmentYears, investmentFuture;

        Console.WriteLine("Enter Investment Amount:");
        investmentAmount = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter annual interest rate in percentage");
        investmentPercent = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter number of years: ");
        investmentYears = double.Parse(Console.ReadLine());

        investmentMonthly = investmentPercent / 12 / 100;
        investmentFuture = investmentAmount * Math.Pow((1 + investmentMonthly), (investmentYears * 12));
        investmentFuture = Math.Round(investmentFuture, 2);

        Console.WriteLine($"Future value is {investmentFuture}");
        Console.WriteLine();


        int hoursWorked;
        double wageAlberta, wageBC, wageOntario;

        Console.WriteLine("Alberta = 15.00");
        Console.WriteLine("BC = 15.50");
        Console.WriteLine("Ontario = 18.30");

        Console.WriteLine("How many hours have you worked");
        hoursWorked = int.Parse(Console.ReadLine());

        wageAlberta = hoursWorked * 15.00;
        wageBC = hoursWorked * 15.50;
        wageOntario = hoursWorked * 18.30;

        Console.WriteLine($"Your wage in Alberta would be {wageAlberta} after working {hoursWorked} hours");
        Console.WriteLine($"Your wage in BC would be {wageBC} after working {hoursWorked} hours");
        Console.WriteLine($"Your wage in Ontario would be {wageOntario} after working {hoursWorked} hours");
        Console.WriteLine();


        double realNum1, realNum2, realNum3, averageMean;

        Console.WriteLine("Enter 3 real Numbers");
        realNum1 = double.Parse(Console.ReadLine());
        realNum2 = double.Parse(Console.ReadLine());
        realNum3 = double.Parse(Console.ReadLine());

        averageMean = (realNum1 + realNum2 + realNum3) / 3;
        averageMean = Math.Round(averageMean, 2);

        Console.WriteLine($"The mean average of {realNum1}, {realNum2}, {realNum3} is {averageMean}");
        Console.WriteLine();
        

        double triBase, triHeight, triHyp;

        Console.WriteLine("Enter the Base and Height of the Triangle");
        triBase = double.Parse(Console.ReadLine());
        triHeight = double.Parse(Console.ReadLine());

        triHyp = Math.Sqrt(Math.Pow(triBase, 2) + Math.Pow(triHeight, 2));

        Console.WriteLine($"The Hypotenuse of the Triangle is {triHyp}");
        Console.WriteLine();


        double num1, num2, add, sub, mul, div, rem;

        Console.WriteLine("Enter the first number:");
        num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        num2 = double.Parse(Console.ReadLine());

        add = num1 + num2;
        sub = num1 - num2;
        mul = num1 * num2;
        div = num1 / num2;
        rem = num1 % num2;

        Console.WriteLine($"The result of adding {num1} and {num2} is {add}");
        Console.WriteLine($"The result of subtracting {num2} from {num1} is {sub}");
        Console.WriteLine($"The result of multiplying {num1} and {num2} is {mul}");
        Console.WriteLine($"The result of dividing {num2} from {num1} is {div}");
        Console.WriteLine($"The result of remainder of dividing {num2} from {num1} is {rem}");
        Console.WriteLine();
        

        double cirRadius, cirArea, cirPerimeter;

        Console.WriteLine("Enter the radius of the circle");
        cirRadius = double.Parse(Console.ReadLine());

        cirArea = Math.PI * Math.Pow(cirRadius, 2);
        cirPerimeter = 2 * Math.PI * cirRadius;

        Console.WriteLine($"The area of a circle with a radius of {cirRadius} is {cirArea}");
        Console.WriteLine($"The Perimeter of a circle with the radius of {cirRadius} is {cirPerimeter}");
        Console.WriteLine();


        double cirDiameter, cirArea2, cirPerimeter2;

        Console.WriteLine("Enter the diamter of the circle");
        cirDiameter = double.Parse(Console.ReadLine());

        cirArea2 = Math.PI * Math.Pow((cirDiameter / 2), 2);
        cirPerimeter2 = cirDiameter * Math.PI;

        Console.WriteLine($"The area of a circle with a diameter of {cirDiameter} is {cirArea2}");
        Console.WriteLine($"The Perimeter of a circle with the diameter of {cirDiameter} is {cirPerimeter2}");
        Console.WriteLine();


        double simpleInterest, amount, rateInterest;
        int years;

        Console.WriteLine("Enter Amount: ");
        amount = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter Rate of interest");
        rateInterest = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter number of years");
        years = int.Parse(Console.ReadLine());

        simpleInterest = (amount * rateInterest * years) / 100;
        
        Console.WriteLine($"The Simple Interest you recieve after depositing ${amount}, with a interest of {rateInterest}% and after {years} years is ${simpleInterest}.");
        Console.WriteLine();


        int ifNumber;
        Console.WriteLine("Enter Any number");
        ifNumber = int.Parse(Console.ReadLine());

        if (ifNumber>=0)
        {
            Console.WriteLine("Number is Positive");
        }
        else
        {
            Console.WriteLine("Number is Negative");
        }

        Console.WriteLine("End of number testing program");
        Console.WriteLine();
        

        int marks;
        Console.WriteLine("Enter yor marks");
        marks = int.Parse(Console.ReadLine());

        if (marks >= 100)
        {
            Console.WriteLine("That extra credit really helped");
        }
        else if (marks >= 80)
        {
            Console.WriteLine("A mark of 'A'");
        }
        else if (marks >= 65)
        {
            Console.WriteLine("A Mark of 'B'");
        }
        else if (marks >= 50)
        {
            Console.WriteLine("A Mark of 'C'");
        }
        else
        {
            Console.WriteLine("Please repeat course");
        }

        Console.WriteLine("End of number testing program");
        Console.WriteLine();
        

        int year;

        Console.WriteLine("Enter a year: ");
        year = int.Parse(Console.ReadLine());

        if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
        {
            Console.WriteLine("It is a leap year");
        }
        else
        {
            Console.WriteLine("It is not a leap year");
        }
        Console.WriteLine();


        double number1, number2, operation, result;

        Console.WriteLine("Enter any 2 numbers: ");
        number1 = double.Parse(Console.ReadLine());
        number2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Select your Choice");
        Console.WriteLine("Type 1 for Addition");
        Console.WriteLine("Type 2 for Subtraction");
        Console.WriteLine("Type 3 for Multiplication");
        Console.WriteLine("Type 4 for Division");
        operation = int.Parse(Console.ReadLine());

        if (operation == 1)
        {
            result = number1 + number2;
            Console.WriteLine($"The result after the operation is {result}");
        }
        else if (operation == 2)
        {
            result = number1 - number2;
            Console.WriteLine($"The result after the operation is {result}");
        }
        else if (operation == 3)
        {
            result = number1 * number2;
            Console.WriteLine($"The result after the operation is {result}");
        }
        else if (operation == 4)
        {
            if(number2 != 0)
            {
                result = number1 / number2;
                Console.WriteLine($"The result after the operation is {result}");
            }
        }
        else
        {
            Console.WriteLine("Please Enter A correct Option");
        }
        Console.WriteLine();


        double switchnumber1, switchnumber2, switchoperation, switchresult;

        Console.WriteLine("Enter any 2 numbers: ");
        switchnumber1 = double.Parse(Console.ReadLine());
        switchnumber2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Select your Choice");
        Console.WriteLine("Type 1 for Addition");
        Console.WriteLine("Type 2 for Subtraction");
        Console.WriteLine("Type 3 for Multiplication");
        Console.WriteLine("Type 4 for Division");
        switchoperation = int.Parse(Console.ReadLine());

        switch (switchoperation)
        {
            case 1:
                switchresult = switchnumber1 + switchnumber2;
                Console.WriteLine($"The result after the operation is {switchresult}");
                break;

            case 2:
                switchresult = switchnumber1 - switchnumber2;
                Console.WriteLine($"The result after the operation is {switchresult}");
                break;

            case 3:
                switchresult = switchnumber1 * switchnumber2;
                Console.WriteLine($"The result after the operation is {switchresult}");
                break;

            case 4:
                if (switchnumber2 != 0)
                {
                    switchresult = switchnumber1 / switchnumber2;
                    Console.WriteLine($"The result after the operation is {switchresult}");
                }
                break;

            default:
                Console.WriteLine("Please Enter A correct Option");
                break;
        }
        Console.WriteLine();


        char choiceISP;
        int hoursISP;
        double costISP;

        Console.WriteLine("Calculate how much your internet bill is right here");
        Console.WriteLine("A | $9.95 per month for up to 10 hours; additional hours are billed at $2.00 per hour");
        Console.WriteLine("B | $13.95 per month for up to 20 hours; additional hours are billed at $1.00 per hour");
        Console.WriteLine("C | $19.95 per month for unlimited hour");
        Console.WriteLine();

        Console.WriteLine("Please Enter Your Package: ");
        choiceISP = char.Parse(Console.ReadLine());

        switch(choiceISP)
        {
            case 'A' or 'a':
                Console.WriteLine("You have selected package A");
                Console.WriteLine("Please Enter Hours Used");
                hoursISP = int.Parse(Console.ReadLine());

                if (hoursISP <= 10)
                {
                    costISP = 9.95;
                }
                else
                {
                    costISP = 9.95 + (hoursISP * 2.00);
                }

                Console.WriteLine($"Your bill would be ${costISP}");
                break;

            case 'B' or 'b':
                Console.WriteLine("You have selected package B");
                Console.WriteLine("Please Enter Hours Used");
                hoursISP = int.Parse(Console.ReadLine());

                if (hoursISP <= 20)
                {
                    costISP = 13.95;
                }
                else
                {
                    costISP = 13.95 + (hoursISP * 1.00);
                }

                Console.WriteLine($"Your bill would be ${costISP}");
                break;

            case 'C' or 'c':
                Console.WriteLine("You have selected package C");
                costISP = 19.95;
                Console.WriteLine($"Your bill would be ${costISP}");
                break;

            default:
                Console.WriteLine("Please enter a valid value");
                break;
        }
        Console.WriteLine();


        int unitChoice;
        double unitConvert, unitResult;

        Console.WriteLine("Choose a Option");
        Console.WriteLine("Type 1 for Pounds to Kilograms");
        Console.WriteLine("Type 2 for Kilograms to Pounds");
        Console.WriteLine("Type 3 for Floud Ounces (US) to Liters");
        Console.WriteLine("Type 4 for Liters to Fluid Ounces (US)");
        Console.WriteLine("Type 5 for Inches To Centimeters");
        Console.WriteLine("Type 6 for Centimeters to Inches");
        Console.WriteLine("Type 7 for Fahrenheit to Celsius");
        Console.WriteLine("Type 8 for Celsius to Fehrenheit");
        unitChoice = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter a Number: ");
        unitConvert = double.Parse(Console.ReadLine());

        switch(unitChoice)
        {
            case 1:
                Console.WriteLine($"Converting {unitConvert} Pounds to Kilograms:");
                unitResult = unitConvert / 2.2046;
                Console.WriteLine($"The Result is {unitResult} Kilograms");
                break;

            case 2:
                Console.WriteLine($"Converting {unitConvert} Kilograms to Pounds:");
                unitResult = unitConvert * 2.2046;
                Console.WriteLine($"The Result is {unitResult} Pounds");
                break;

            case 3:
                Console.WriteLine($"Converting {unitConvert} Fluid Ounces to Liters:");
                unitResult = unitConvert / 33.8140226;
                Console.WriteLine($"The Result is {unitResult} Liters");
                break;

            case 4:
                Console.WriteLine($"Converting {unitConvert} Liters to Fluid Ounces:");
                unitResult = unitConvert * 33.8140226;
                Console.WriteLine($"The Result is {unitResult} Fluid Ounces");
                break;

            case 5:
                Console.WriteLine($"Converting {unitConvert} Inches to Centimeters:");
                unitResult = unitConvert / 0.39370;
                Console.WriteLine($"The Result is {unitResult} Centimeters");
                break;

            case 6:
                Console.WriteLine($"Converting {unitConvert} Centimeters to Inches:");
                unitResult = unitConvert * 0.39370;
                Console.WriteLine($"The Result is {unitResult} Inches");
                break;

            case 7:
                Console.WriteLine($"Converting {unitConvert} Fahrenheit to Celsius:");
                unitResult = (unitConvert - 32) / 1.800;
                Console.WriteLine($"The Result is {unitResult} Celsius");
                break;

            case 8:
                Console.WriteLine($"Converting {unitConvert} Celsius to Fahrenheit:");
                unitResult = unitConvert * 1.800 + 32;
                Console.WriteLine($"The Result is {unitResult} Fahrenheit");
                break;

            default:
                Console.WriteLine("Enter a Valid Value");
                break;
        }
        Console.WriteLine();


        double moneyFederal, taxFederal, taxRateFederal;

        Console.WriteLine("Enter your taxable income:");
        moneyFederal = double.Parse(Console.ReadLine());

        if (moneyFederal <= 45916)
        {
            taxRateFederal = 0.15;
            taxFederal = moneyFederal * taxRateFederal;
        }
        else if (moneyFederal <= 91831)
        {
            taxRateFederal = 0.205;
            taxFederal = 6887 + (moneyFederal - 45916) * taxRateFederal;
        }
        else if (moneyFederal <= 142353)
        {
            taxRateFederal = 0.26;
            taxFederal = 16300 + (moneyFederal - 91831) * taxRateFederal;
        }
        else if (moneyFederal <= 202800)
        {
            taxRateFederal = 0.29;
            taxFederal = 29436 + (moneyFederal - 142353) * taxRateFederal;
        }
        else
        {
            taxRateFederal = 0.33;
            taxFederal = 46965 + (moneyFederal - 202800) * taxRateFederal;
        }

        taxFederal = Math.Round(taxFederal, 2);
        Console.WriteLine($"Your federal tax rate is {taxRateFederal * 100}% and you owe the federal government ${taxFederal} in taxes");
        Console.WriteLine();


        int yearZodiac, remainderZodiac;

        Console.WriteLine("Enter a year: ");
        yearZodiac = int.Parse(Console.ReadLine());

        remainderZodiac = yearZodiac % 12;

        switch(remainderZodiac)
        {
            case 0:
                Console.WriteLine("Monke");
                break;
            case 1:
                Console.WriteLine("Cock");
                break;
            case 2:
                Console.WriteLine("Doge");
                break;
            case 3:
                Console.WriteLine("Oink");
                break;
            case 4:
                Console.WriteLine("Average Tarkov Player");
                break;
            case 5:
                Console.WriteLine("Ox");
                break;
            case 6:
                Console.WriteLine("Tigr");
                break;
            case 7:
                Console.WriteLine("Ribbit");
                break;
            case 8:
                Console.WriteLine("Dorgon");
                break;
            case 9:
                Console.WriteLine("Snek");
                break;
            case 10:
                Console.WriteLine("Horse");
                break;
            case 11:
                Console.WriteLine("Shep");
                break;
        }
        Console.WriteLine();


        int infinite = 0;

        while (infinite <= 100000)
        {
            Console.WriteLine(infinite++);
        }
        Console.WriteLine();


        int loopStart, loopEnd;

        Console.WriteLine("Enter the beginning and End value");
        loopStart = int.Parse(Console.ReadLine());
        loopEnd = int.Parse(Console.ReadLine());

        while (loopStart <= loopEnd)
        {
            Console.Write(loopStart++);
        }
        Console.WriteLine();


        Console.WriteLine("While Loop: ");
        int whileLoop = 1;

        while (whileLoop <= 5)
        {
            Console.WriteLine(whileLoop++);
        }
        Console.WriteLine();


        Console.WriteLine("For Loop: ");
        int forLoop = 1;

        for (forLoop = 1; forLoop <= 5; ++forLoop)
        {
            Console.WriteLine(forLoop);
        }
        Console.WriteLine();


        Console.WriteLine("Do Loop: ");
        int doLoop = 1;
        do
        {
            Console.Write(doLoop++);
        } while (doLoop <= 5);
        Console.WriteLine();
        

        int whilePractice, whileTrack = 1;

        Console.Write("Enter Any Number: ");
        whilePractice = int.Parse(Console.ReadLine());

        while (whileTrack <= 10)
        {
            Console.WriteLine($"{whilePractice} x {whileTrack} = {whilePractice * whileTrack}");
            whileTrack++;
        }
        Console.WriteLine();
        

        //Declaring Variables
        double sqrtInput, sqrtOutput;
        // sqrtInput is Input
        // sqrtOutput is output
        
        // Get Value from User
        Console.WriteLine("Enter a Number: ");
        sqrtInput = double.Parse(Console.ReadLine());

        // Calculating Square Root
        sqrtOutput = Math.Round(Math.Sqrt(sqrtInput), 2);

        // Outputting Result
        Console.WriteLine($"The sqrt of {sqrtInput} is {sqrtOutput}");
        Console.WriteLine();


        // Declaring Variables
        double sinInput, sinOutput;
        // sinInput is Input
        // sinOutput is Output

        // Get Value from User
        Console.WriteLine("Enter a Number in Degrees: ");
        sinInput = double.Parse(Console.ReadLine());

        // Calculating Sin Value
        sinInput = sinInput * Math.PI / 180;
        sinOutput = Math.Sin(sinInput);

        // Outputting Result
        Console.WriteLine($"The Sin Value is {sinOutput}");
        Console.WriteLine();


        // Declaring Variables
        double cosInput, cosOutput;
        // sinInput is Input
        // sinOutput is Output

        // Get Value from User
        Console.WriteLine("Enter a Number in Degrees: ");
        cosInput = double.Parse(Console.ReadLine());

        // Calculating Cos Value
        cosInput = sinInput * Math.PI / 180;
        cosOutput = Math.Cos(sinInput);

        // Outputting Result
        Console.WriteLine($"The Cos Value is {cosOutput}");
        Console.WriteLine();
        
        
        // Declaring Variables
        double preLabInput, preLabOutput;
        int preLabMenu;
        // preLabInput is Input
        // preLabOutput is Output
        // preLabMenu is menu Interaction

        // Get Input from User
        Console.WriteLine("Enter a Number: ");
        preLabInput = double.Parse(Console.ReadLine());

        // Menu to user
        Console.WriteLine("Type 1 for Sqrt");
        Console.WriteLine("Type 2 for Sin Value");
        Console.WriteLine("Type 3 for Cos Value");
        Console.WriteLine("Type 4 for Sin + Cos");
        Console.WriteLine();

        // Get Menu Input
        Console.WriteLine("Enter your choice");
        preLabMenu = int.Parse(Console.ReadLine());

        switch (preLabMenu)
        {
            case 1: // sqrt
                // Calculate Sqrt
                preLabOutput = Math.Round(Math.Sqrt(preLabInput), 2);
                Console.WriteLine($"The sqrt of {preLabInput} is {preLabOutput}");
                break;

            case 2: // Sin
                preLabInput = preLabInput * Math.PI / 180;
                preLabOutput = Math.Sin(preLabInput);
                Console.WriteLine($"The Sin Value is {preLabOutput}");
                break;

            case 3: // Cos
                preLabInput = preLabInput * Math.PI / 180;
                preLabOutput = Math.Cos(preLabInput);
                Console.WriteLine($"The Cos Value is {preLabOutput}");
                break;

            case 4: // Sin + Cos
                preLabInput = preLabInput * Math.PI / 180;
                preLabOutput = Math.Sin(preLabInput) + Math.Cos(preLabInput);
                Console.WriteLine($"The Value of Sin + Cos is {preLabOutput}");
                break;

            default: // If not a valid menu option
                Console.WriteLine("Please Enter a Valid Option");
                break;
        }
        Console.WriteLine();
        

        // Declaring Variables
        double time, speed, distance;
        // time is Input
        // speed is Input
        // distance is Output

        // Get User Input
        Console.WriteLine("Enter Time and Speed");
        time = double.Parse(Console.ReadLine());
        speed = double.Parse(Console.ReadLine());

        // Calculating Distance
        distance = time * speed;

        // Outputting Value
        Console.WriteLine($"You Travelled an Arbitrary distance of {distance}");
        

        // Declaring Variables
        double menuTime, menuSpeed, menuDistance;
        int menuInputTSD;
        // menuTime is Input or Output
        // menuSpeed is Input or Output
        // menuDistance Input or Output
        //menuInputTSD is the variable that holds the menu choice for switch

        // Get User Input
        Console.WriteLine("Press 1 if you know time and distance");
        Console.WriteLine("Press 2 if you know time and speed");
        Console.WriteLine("Press 3 if you know speed and distance");
        menuInputTSD = int.Parse(Console.ReadLine());
        Console.WriteLine();

        // Doing Menu
        switch (menuInputTSD)
        {
            case 1: // User knows time and distance
                // get User Input
                Console.WriteLine("Enter Time: ");
                menuTime = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter Distance: ");
                menuDistance = double.Parse(Console.ReadLine());

                // Calculating Output
                menuSpeed = menuDistance / menuTime;

                // Outputting Result
                Console.WriteLine($"The Speed is {menuSpeed}");
                break;

            case 2: // User knows time and speed
                // get User Input
                Console.WriteLine("Enter Time: ");
                menuTime = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter Speed: ");
                menuSpeed = double.Parse(Console.ReadLine());

                // Calculating Output
                menuDistance = menuSpeed * menuTime;

                // Outputting Result
                Console.WriteLine($"The Distance is {menuDistance}");
                break;

            case 3: // User knows speed and distance
                // get User Input
                Console.WriteLine("Enter Speed: ");
                menuSpeed = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter Distance: ");
                menuDistance = double.Parse(Console.ReadLine());

                // Calculating Output
                menuTime = menuDistance / menuSpeed;

                // Outputting Result
                Console.WriteLine($"The Time is {menuTime}");
                break;

            default: // When user inputs a invalid value for menu
                Console.WriteLine("Invalid Input for Menu");
                break;
        }
        Console.WriteLine();
        

        int randNumber = randValue.Next(1, 101);
        int userRandValue;

        Console.Write("Enter your Guess: ");
        userRandValue = int.Parse(Console.ReadLine());

        if (userRandValue == randNumber)
        {
            Console.WriteLine("You guessed correctly, you ge a cookie!");
        }
        else
        {
            Console.WriteLine("You did not guess correctly, perish");
            Console.WriteLine($"The Correct value is {randNumber}");
        }
        Console.WriteLine();
        

        double mySquareInput, mySquareOutput = 0;

        Console.Write("Enter a Number: ");
        mySquareInput = double.Parse(Console.ReadLine());

        for (int mySquareCounter = 0; mySquareCounter <= mySquareInput; mySquareCounter++)
        {
            mySquareOutput += mySquareCounter * mySquareCounter;
        }
        Console.WriteLine(mySquareOutput);
        Console.WriteLine();
        

        string ageInput;
        int ageCount = 0;
        double ageOutput = 0;

        while (true)
        {
            Console.Write("Enter a Person's Age: ");
            ageInput = Console.ReadLine();

            if (ageInput == "" || ageInput == "0")
            {
                ageOutput = ageOutput / ageCount;
                break;
            }
            else
            {
                ageCount++;
                ageOutput += int.Parse(ageInput);
            }
        }
        Console.WriteLine($"The Average age of these {ageCount} people is {ageOutput} years old.");
        Console.WriteLine();
        

        int calendarMonth, calendarStart, calendarLoop1, calendarLoop2, calendarCount, calendarDay;

        calendarLoop1 = 1;
        calendarCount = 1;

        Console.Write("Number of Days in the Month: ");
        calendarMonth = int.Parse(Console.ReadLine());

        Console.Write("What Day of the Week does the Month Start On: ");
        calendarDay = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");

        while (calendarLoop1 <= 6)
        {
            calendarLoop2 = 1;
            while (calendarLoop2 <= 7)
            {
                if (calendarLoop1 == 1 && calendarLoop2 < calendarDay)
                {
                    Console.Write("    ");
                }
                else
                {
                    if (calendarCount <= calendarMonth)
                    {
                        Console.Write("{0,3:0} ", calendarCount);
                        calendarCount++;
                    }
                    else
                    {
                        break;
                    }
                }
                 
                calendarLoop2++;
            }

            if (calendarCount > calendarMonth)
            {
                break;
            }
            else
            {
                Console.Write("\n");
                calendarLoop1++;
            }
        }
        Console.WriteLine();
        

        int gameRandAnswer, gameRandInput, gameGuessCount;

        gameRandAnswer = randValue.Next(1, 101);
        gameGuessCount = 0;

        while (true)
        {
            Console.Write("Enter a Guess: ");
            gameRandInput = int.Parse(Console.ReadLine());

            if (gameRandInput > gameRandAnswer)
            {
                Console.WriteLine("Your Guess is Too High");
                gameGuessCount++;
            }
            else if (gameRandInput < gameRandAnswer)
            {
                Console.WriteLine("Your Guess is Too Low");
                gameGuessCount++;
            }
            else
            {
                Console.WriteLine($"You Guessed Correctly, You made {++gameGuessCount} Guesses");
                break;
            }
        }
        Console.WriteLine();
        

        char choiceISPLoop;
        int hoursISPLoop;
        double costISPLoop;
        bool ISPLoop = true;

        while (ISPLoop)
        {
            Console.WriteLine("Calculate how much your internet bill is right here");
            Console.WriteLine("A | $9.95 per month for up to 10 hours; additional hours are billed at $2.00 per hour");
            Console.WriteLine("B | $13.95 per month for up to 20 hours; additional hours are billed at $1.00 per hour");
            Console.WriteLine("C | $19.95 per month for unlimited hour");
            Console.WriteLine("D | Exit Program");
            Console.WriteLine();

            Console.Write("Please Enter Your Package: ");
            choiceISPLoop = char.Parse(Console.ReadLine());

            switch (choiceISPLoop)
            {
                case 'A' or 'a':
                    Console.WriteLine("You have selected package A");
                    Console.Write("Please Enter Hours Used: ");
                    hoursISPLoop = int.Parse(Console.ReadLine());

                    if (hoursISPLoop <= 10)
                    {
                        costISPLoop = 9.95;
                    }
                    else
                    {
                        costISPLoop = 9.95 + (hoursISPLoop * 2.00);
                    }

                    Console.WriteLine($"Your bill would be ${costISPLoop}");
                    break;

                case 'B' or 'b':
                    Console.WriteLine("You have selected package B");
                    Console.Write("Please Enter Hours Used: ");
                    hoursISPLoop = int.Parse(Console.ReadLine());

                    if (hoursISPLoop <= 20)
                    {
                        costISPLoop = 13.95;
                    }
                    else
                    {
                        costISPLoop = 13.95 + (hoursISPLoop * 1.00);
                    }

                    Console.WriteLine($"Your bill would be ${costISPLoop}");
                    break;

                case 'C' or 'c':
                    Console.WriteLine("You have selected package C");
                    costISPLoop = 19.95;
                    Console.WriteLine($"Your bill would be ${costISPLoop}");
                    break;

                default:
                    ISPLoop = false;
                    break;
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        

        int simpleLoop1;
        int lastNumber1;

        simpleLoop1 = 1;

        Console.Write("Last Number: ");
        lastNumber1 = int.Parse(Console.ReadLine());

        while (simpleLoop1 <= lastNumber1)
        {
            Console.Write($"{simpleLoop1++} ");
        }
        Console.WriteLine();
        Console.WriteLine();

        int simpleLoop2;
        int lastNumber2;

        simpleLoop2 = 1;

        Console.Write("Last Number: ");
        lastNumber2 = int.Parse(Console.ReadLine());

        while (simpleLoop2 <= lastNumber2)
        {
            Console.Write($"{simpleLoop2++ * 2} ");
        }
        Console.WriteLine();
        Console.WriteLine();


        int simpleLoop3;
        int lastNumber3;
        int addition3;

        simpleLoop3 = 1;
        addition3 = 0;

        Console.Write("Last Number: ");
        lastNumber3 = int.Parse(Console.ReadLine());

        while (simpleLoop3 <= lastNumber3)
        {
            if (lastNumber3 != simpleLoop3)
            {
                addition3 += simpleLoop3;
                Console.Write($"{simpleLoop3++} + ");
            }
            else
            {
                addition3 += simpleLoop3;
                Console.WriteLine(simpleLoop3++);
            }
        }
        Console.WriteLine(addition3);
        Console.WriteLine();

        int simpleLoop4;
        int lastNumber4;
        int addition4;

        simpleLoop4 = 1;
        addition4 = 0;

        Console.Write("Last Number: ");
        lastNumber4 = int.Parse(Console.ReadLine());

        while (simpleLoop4 <= lastNumber4)
        {
            if (lastNumber4 != simpleLoop4)
            {
                addition4 += simpleLoop4 * 2;
                Console.Write($"{simpleLoop4++ * 2} + ");
            }
            else
            {
                addition4 += simpleLoop4 * 2;
                Console.WriteLine(simpleLoop4++ * 2);
            }
        }
        Console.WriteLine(addition4);
        Console.WriteLine();
        

        double salaryBase, salaryGross;
        int month, monthLoop;

        monthLoop = 1;

        Console.Write("Base Salary: ");
        salaryBase = double.Parse(Console.ReadLine());

        Console.Write("Current Month: ");
        month = int.Parse(Console.ReadLine());

        Console.WriteLine("Jan    Feb    Mar    Apr    May    Jun    Jul    Aug    Sep    Oct    Nov    Dec");

        while (monthLoop <= 12)
        {
            if (monthLoop < month)
            {
                Console.Write("      ");
            }
            else
            {
                salaryGross = salaryBase * 1.10;
                Console.Write("{0,7:0}", salaryGross);
            }
            monthLoop++;
        }
        Console.WriteLine();
        

        double finalPopulation, initialPopulation;
        int growthRate, timeBacteria, daysBacteria;

        timeBacteria = 1;

        Console.Write("Initial Population: ");
        initialPopulation = double.Parse(Console.ReadLine());

        Console.Write("Growth Rate as a Percentage: ");
        growthRate = int.Parse(Console.ReadLine());

        growthRate = growthRate / 100;

        Console.Write("Number of Days: ");
        daysBacteria = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine($"Bacteria Growth Over {daysBacteria} Days");
        Console.WriteLine();
        Console.WriteLine("  Day  |  Population  ");

        while (true)
        {
            Console.Write("{0,5:0}  |", timeBacteria);
            
            finalPopulation = initialPopulation * Math.Pow(Math.E, growthRate * timeBacteria);
            initialPopulation = finalPopulation;

            Console.Write("{0,10:0}\n", finalPopulation);

            timeBacteria++;

            if (timeBacteria > daysBacteria)
            {
                break;
            }
        }
        Console.WriteLine();
        

        int zero1, zero2, zero3;

        zero1 = 1;
        zero2 = 0;

        try
        {
            zero3 = zero1 / zero2;
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
        Console.WriteLine();
        

        string writerName;

        StreamWriter writer;
        writer = new StreamWriter("E:/Programming/TextDocuments/test.txt");
        // OR
        // StreamWriter writer = new StreamWriter("E:/Programming/TextDocuments/test.txt");

        Console.Write("Enter Your Name: ");
        writerName = Console.ReadLine();

        writer.WriteLine(writerName);

        writer.Close();
        Console.WriteLine();

        string readerOutput;
        StreamReader reader = null;

        try
        {
            
            reader = new StreamReader("E:/Programming/TextDocuments/test.txt");
            readerOutput = reader.ReadLine();
            // OR
            // StreamReader reader = new StreamReader("E:/Programming/TextDocuments/test.txt");

            Console.WriteLine(readerOutput);
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
        finally
        {
            reader.Close();
        }
        Console.WriteLine();
        */

        int lastElement;
        StreamWriter loopWriter = null;

        try
        {
            loopWriter = new StreamWriter("E:/Programming/TextDocuments/test.txt");

            Console.Write("Enter the Last Number: ");
            lastElement = int.Parse(Console.ReadLine());

            Console.Clear();

            for (int i = 1; i <= lastElement; i++)
            {
                loopWriter.WriteLine(i);
            }
            Console.WriteLine("You Can Check the Output in E:/Programming/TextDocuments/test.txt");
            loopWriter.Close();
        }
        catch (Exception exp)
        {
            Console.WriteLine(exp.Message);
        }
        Console.WriteLine();

        
        string loopReaderLine;
        StreamReader loopReader = null;

        try
        {
            loopReader = new StreamReader("E:/Programming/TextDocuments/test.txt");

            while (loopReader.EndOfStream == false)
            {
                loopReaderLine = loopReader.ReadLine();
                Console.WriteLine(loopReaderLine);
            }
            loopReader.Close();
        }
        catch (Exception exp)
        {
            Console.WriteLine(exp.Message);
        }
        Console.WriteLine();
    }
}