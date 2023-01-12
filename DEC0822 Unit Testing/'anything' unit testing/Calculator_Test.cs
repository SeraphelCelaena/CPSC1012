using DEC0822_Unit_Testing;

namespace _anything__unit_testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(1, 2, 3)]
        [DataRow(-1, 2, 1)]
        [DataRow(3 -2, 1)]
        [DataRow(-1, -2, -3)]
        public void TestMethod1(int input1, int input2, int output)
        {
            // Arrange
            Calculator c1 = new Calculator(input1, input2);

            // Act
            int result = c1.Add();
            
            // Assert
            Assert.AreEqual(output, result);
        }
    }
}