/*
Purpose:  Assignment 4 Part 3
Input: 
Output: 
Written by: Andrew Ng
Written for: Harsimranjot Singh Aulakh
Section: A06
Last Modified Date: December 14, 2022
*/

using System;

namespace Assignment4Part3_AndrewNG
{
    public class Person
    {
        string _name;
        DateTime _birthDate;

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                if (value.Trim() == "")
                {
                    throw new Exception("Name cannot be blank");
                }
                else if (value.Length < 5)
                {
                    throw new Exception("Name must contain 5 or more characters");
                }
                else
                {
                    _name = value;
                }
            }
        }

        public DateTime BirthDate
        {
            get
            {
                return _birthDate;
            }

            set
            {
                if (DateTime.Now > value)
                {
                    throw new Exception("BirthDate cannot be in the future");
                }
                else
                {
                    _birthDate = value;
                }
            }
        }

        public Person(string name, DateTime birthDate)
        {
            Name = name;
            BirthDate = birthDate;
        }

        public readonly int CurrentAge = DateTime.Now.Year - BirthDate.Year;

        public int AgeOn(DateTime onDate)
        {
            int output;

            output = onDate.Year - BirthDate.Year;

            return output;
        }

        public string ChineseZodiac()
        {
            int indexZodiac = BirthDate.Year % 12;
            string[] arrayZodiac = { "Monkey", "Rooster", "Dog", "Pig", "Rat", "Ox", "Tiger", "Rabbit", "Dragon", "Snake", "Horse", "Sheep" };

            return arrayZodiac[indexZodiac];
        }

        public string AstrologicalSign()
        {
            int index;
            string[] arrayAstrology = { "Aries", "Taurus", "Gemini", "Cancer", "Leo", "Virgo", "Libra", "Scorpio", "Sagittarius", "Capricorn", "Aquarious", "Pisces" };
            DateTime[] times = { DateTime.Parse("March 21"), DateTime.Parse("April 20"), DateTime.Parse("May 21"), DateTime.Parse("June 22"), DateTime.Parse("July 23"), DateTime.Parse("August 23"), DateTime.Parse("September 23"), DateTime.Parse("October 23"), DateTime.Parse("November 23"), DateTime.Parse("December 22"), DateTime.Parse("January 20") };

            if (BirthDate >= times[0] && times[1] > BirthDate)
            {
                index = 0;
            }
            else if (BirthDate >= times[1] && times[2] > BirthDate)
            {
                index = 1;
            }
            else if (BirthDate >= times[2] && times[3] > BirthDate)
            {
                index = 2;
            }
            else if (BirthDate >= times[3] && times[4] > BirthDate)
            {
                index = 3;
            }
            else if (BirthDate >= times[4] && times[5] > BirthDate)
            {
                index = 4;
            }
            else if (BirthDate >= times[5] && times[6] > BirthDate)
            {
                index = 5;
            }
            else if (BirthDate >= times[6] && times[7] > BirthDate)
            {
                index = 6;
            }
            else if (BirthDate >= times[7] && times[8] > BirthDate)
            {
                index = 7;
            }
            else if (BirthDate >= times[8] && times[9] > BirthDate)
            {
                index = 8;
            }
            else if (BirthDate >= times[9] && times[10] > BirthDate)
            {
                index = 9;
            }
            else if (BirthDate >= times[10] && times[11] > BirthDate)
            {
                index = 10;
            }
            else
            {
                index = 11;
            }

            return arrayAstrology[index];
        }
    }
}