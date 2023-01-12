using System;

namespace Assignment4Part3_AntonioSolito
{
    public class Person
    {
        string _name;
        DateTime _birthDate;

        public string Name
        {
            get { return _name; }

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
            get { return _birthDate; }

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

        public readonly int CurrentAge;

        public int AgeOn(DateTime onDate)
        {
            return onDate.Year - BirthDate.Year;
        }

        public string ChineseZodiac()
        {
            int zodiac = BirthDate.Year % 12;
            string output;

            switch (zodiac)
            {
                case 0:
                    output = "Monkey";
                    break;

                case 1:
                    output = "Rooster";
                    break;

                case 2:
                    output = "Dog";
                    break;

                case 3:
                    output = "Pig";
                    break;

                case 4:
                    output = "Rat";
                    break;

                case 5:
                    output = "Ox";
                    break;

                case 6:
                    output = "Tiger";
                    break;

                case 7:
                    output = "Rabbit";
                    break;

                case 8:
                    output = "Dragon";
                    break;

                case 9:
                    output = "Snake";
                    break;

                case 10:
                    output = "Horse";
                    break;

                case 11:
                    output = "Sheep";
                    break;

                default:
                    output = "";
                    break;
            }

            return output;
        }

        public string AstrologicalSign()
        {
            string output;

            if (BirthDate >= DateTime.Parse("March 21") && DateTime.Parse("April 19") >= BirthDate)
            {
                output = "Aries";
            }
            else if (BirthDate >= DateTime.Parse("April 20") && DateTime.Parse("May 20") >= BirthDate)
            {
                output = "Taurus";
            }
            else if (BirthDate >= DateTime.Parse("May 21") && DateTime.Parse("June 21") >= BirthDate)
            {
                output = "Gemini";
            }
            else if (BirthDate >= DateTime.Parse("June 22") && DateTime.Parse("July 22") >= BirthDate)
            {
                output = "Cancer";
            }
            else if (BirthDate >= DateTime.Parse("July 23") && DateTime.Parse("August 22") >= BirthDate)
            {
                output = "Leo";
            }
            else if (BirthDate >= DateTime.Parse("August 23") && DateTime.Parse("September 22") >= BirthDate)
            {
                output = "Virgo";
            }
            else if (BirthDate >= DateTime.Parse("September 23") && DateTime.Parse("October 22") >= BirthDate)
            {
                output = "Libra";
            }
            else if (BirthDate >= DateTime.Parse("October 23") && DateTime.Parse("November 22") >= BirthDate)
            {
                output = "Scorpio";
            }
            else if (BirthDate >= DateTime.Parse("November 23") && DateTime.Parse("December 21") >= BirthDate)
            {
                output = "Sagittarius";
            }
            else if (BirthDate >= DateTime.Parse("December 22") && DateTime.Parse("January 19") >= BirthDate)
            {
                output = "Capricorn";
            }
            else if (BirthDate >= DateTime.Parse("January 20") && DateTime.Parse("February 18") >= BirthDate)
            {
                output = "Aquarious";
            }
            else
            {
                output = "Pisces";
            }

            return output;
        }
    }
}