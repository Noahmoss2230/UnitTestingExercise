using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1, 2, 3, 6)]
        [InlineData(5,5,5,15)]
        [InlineData(10,10,10,30)]
        [InlineData(15,15,15,45)]
        [InlineData(4,7,9,20)]
        [InlineData(10,15,3,28)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            var test = new UnitTestMethods();
            // create a Calculator object


            //Act
            var actual = test.Add(num1, num2, num3);
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5,5,0)]
        [InlineData(25,5,20)]
        [InlineData(30,10,20)]
        [InlineData(35,15,20)]
        [InlineData(40,20,20)]
        //Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var tester = new UnitTestMethods();

            //Act
            var actual = tester.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(2,2,4)]
        [InlineData(4,5,20)]
        [InlineData(5,5,25)]
        [InlineData(5,10,50)]
        [InlineData(3,15,45)]
        //Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var test = new UnitTestMethods();

            //Act
            var actual = test.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(4,2,2)]
        [InlineData(8,2,4)]
        [InlineData(16,4,4)]
        [InlineData(32,8,4)]
        [InlineData(12,3,4)]
        //Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var tester = new UnitTestMethods();

            //Act
            var actual = tester.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

    }
}
