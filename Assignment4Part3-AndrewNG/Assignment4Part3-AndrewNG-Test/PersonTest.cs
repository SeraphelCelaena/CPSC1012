using Assignment4Part3_AndrewNG;

namespace Assignment4Part3_AndrewNG_Test{

    /*
     * https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-best-practices
     * 
     * Naming your tests
     * The name of your test should consist of three parts:
     *  - The name of the method being tested.
     *  - The scenario under which it's being tested.
     *  - The expected behavior when the scenario is invoked.
     *  
     * Arrange, Act, Assert is a common pattern when unit testing. As the name implies, it consists of three main actions:
     *  - Arrange your objects, create and set them up as necessary.
     *  - Act on an object.
     *  - Assert that something is as expected.
     *  
    */

    [TestClass]
    public class PersonTest
    {

        [TestMethod]
        [DataRow("", "Name cannot be blank")]
        [DataRow("              ", "Name cannot be blank")]
        public void Name_BlankName_ThrowsException(string name, string expectedErrorMessage)
        {
            // Arrange 
            DateTime today = DateTime.Today;

            // Act
            try
            {
                Person currentPerson = new Person(name, today);
                Assert.Fail("An exception should have been thrown");
            }
            catch (ArgumentException e)
            {
                // Assert
                StringAssert.Contains(e.Message, expectedErrorMessage);
            }

        }

        [TestMethod]
        [DataRow("U", "Name must contain 5 or more characters")]
        [DataRow("Un", "Name must contain 5 or more characters")]
        [DataRow("Unc", "Name must contain 5 or more characters")]
        [DataRow("Uncl", "Name must contain 5 or more characters")]
        public void Name_MinimumNameLength_ThrowsException(string name, string expectedErrorMessage)
        {
            // Arrange 
            DateTime today = DateTime.Today;

            // Act
            try
            {
                Person currentPerson = new Person(name, today);
                Assert.Fail("An exception should have been thrown");
            }
            catch (ArgumentException e)
            {
                // Assert
                StringAssert.Contains(e.Message, expectedErrorMessage);
            }

        }

        [TestMethod]
        [DataRow("2022-12-25", "BirthDate cannot be in the future")]
        [DataRow("2023-01-09", "BirthDate cannot be in the future")]
        public void BirthDate_FutureDate_ThrowsException(string birthDateString, string expectedErrorMessage)
        {
            // Arrange 
            string name = "Uncle Bob";
            DateTime birthDate = DateTime.Parse(birthDateString);

            // Act
            try
            {
                Person currentPerson = new Person(name, birthDate);
                Assert.Fail("An exception should have been thrown");
            }
            catch (ArgumentException e)
            {
                // Assert
                StringAssert.Contains(e.Message, expectedErrorMessage);
            }

        }

        [TestMethod]
        [DataRow("Queen Elizabeth II", "1926-04-21", 96)]
        [DataRow("King Charles III", "1948-11-14", 74)]
        [DataRow("Prince William of Wales", "1982-06-21", 40)]
        [DataRow("Prince George of Wales", "2013-07-22", 9)]
        //[DataRow("Uncle Bob","1952-12-05",69)] // uncomment if running test before Dec 5
        public void CurrentAge_KnownAge_ReturnsAge(string name, string birthDateString, int expectedAge)
        {
            // Arrange and Act
            DateTime birthDate = DateTime.Parse(birthDateString);
            Person currentPerson = new Person(name, birthDate);
            // Assert
            Assert.AreEqual(expectedAge, currentPerson.CurrentAge);
        }

        [TestMethod]
        [DataRow("Queen Elizabeth II", "1926-04-21", "2022-09-08", 96)]
        [DataRow("King Charles III", "1948-11-14", "2022-09-08", 73)]
        [DataRow("Uncle Bob", "1952-12-05", "2022-12-15", 70)]
        public void AgeOn_FutureDate_ReturnsAge(string name, string birthDateString, string onDateString, int expectedAge)
        {
            // Arrange and Act
            DateTime birthDate = DateTime.Parse(birthDateString);
            DateTime onDate = DateTime.Parse(onDateString);
            Person currentPerson = new Person(name, birthDate);
            // Assert
            Assert.AreEqual(expectedAge, currentPerson.AgeOn(onDate));
        }

        [TestMethod]
        [DataRow("1900-01-01", "Rat")]
        [DataRow("1901-01-01", "Ox")]
        [DataRow("1902-01-01", "Tiger")]
        [DataRow("1903-01-01", "Rabbit")]
        [DataRow("1904-01-01", "Dragon")]
        [DataRow("1905-01-01", "Snake")]
        [DataRow("1906-01-01", "Horse")]
        [DataRow("1907-01-01", "Sheep")]
        [DataRow("1908-01-01", "Monkey")]
        [DataRow("1909-01-01", "Rooster")]
        [DataRow("1910-01-01", "Dog")]
        [DataRow("1911-01-01", "Pig")]
        public void ChineseZodiac_YearsForAllAnimals_ReturnsAnimal(string birthDateString, string expectedChineseZodiac)
        {
            // Arrange and Act
            DateTime birthDate = DateTime.Parse(birthDateString);
            Person currentPerson = new Person("Chinese Zodiac", birthDate);
            // Assert
            Assert.AreEqual(expectedChineseZodiac.ToUpper(), currentPerson.ChineseZodiac().ToUpper());
        }

        [TestMethod]
        [DataRow("1900-03-21", "Aries")]
        [DataRow("1900-04-19", "Aries")]
        [DataRow("1900-04-20", "Taurus")]
        [DataRow("1900-05-20", "Taurus")]
        [DataRow("1900-05-21", "Gemini")]
        [DataRow("1900-06-21", "Gemini")]
        [DataRow("1900-06-22", "Cancer")]
        [DataRow("1900-07-22", "Cancer")]
        [DataRow("1900-07-23", "Leo")]
        [DataRow("1900-08-22", "Leo")]
        [DataRow("1900-08-23", "Virgo")]
        [DataRow("1900-09-22", "Virgo")]
        [DataRow("1900-09-23", "Libra")]
        [DataRow("1900-10-22", "Libra")]
        [DataRow("1900-10-23", "Scorpio")]
        [DataRow("1900-11-22", "Scorpio")]
        [DataRow("1900-11-23", "Sagittarius")]
        [DataRow("1900-12-21", "Sagittarius")]
        [DataRow("1900-12-22", "Capricorn")]
        [DataRow("1900-01-19", "Capricorn")]
        [DataRow("1900-01-20", "Aquarius")]
        [DataRow("1900-02-18", "Aquarius")]
        [DataRow("1900-02-19", "Pisces")]
        [DataRow("1900-03-20", "Pisces")]
        public void AstrologicalSign_AllSignDateRanges_ReturnSign(string birthDateString, string expectedAstrologicalSign)
        {
            // Arrange and Act
            DateTime birthDate = DateTime.Parse(birthDateString);
            Person currentPerson = new Person("Astrological Sign", birthDate);
            // Assert
            Assert.AreEqual(expectedAstrologicalSign.ToUpper(), currentPerson.AstrologicalSign().ToUpper());
        }

    }
}
