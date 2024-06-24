using NuGet.Frameworks;
using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(3, 4, 1, 8)]
        [InlineData(-2, -2, -2, -6)]
        [InlineData(-3,0,-1,-4)]
        [InlineData(0,0,1,1)]

            
        //Add test data ^
        public void AddTest(int number1, int number2, int number3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            Calculator instance = new Calculator();
            

            //Act
            int actual = instance.Add(number1, number2, number3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(7,5,2)]
        [InlineData(10,5,5)]
        [InlineData(9,3,6)]
        [InlineData(20,10,10)]
        [InlineData(12,6,6)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            Calculator instance = new Calculator();
            //Act
            int actual = instance.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5,5,25)]
        [InlineData(4,5,20)]
        [InlineData(1,1,1)]
        [InlineData(0,0,0)]
        [InlineData(3,3,9)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:
            Calculator instance = new Calculator();
            //Arrange

            //Act
            int actual = instance.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2,2,1)]
        [InlineData(10,5,2)]
        [InlineData(4,2,2)]
        [InlineData(10, 10, 1)]
        [InlineData(20,10,2)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            Calculator instance = new Calculator();
            //Act
            int actual = instance.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
