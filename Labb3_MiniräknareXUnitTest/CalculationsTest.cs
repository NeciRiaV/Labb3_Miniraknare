using System;
using Xunit;
using Labb3_MiniräknareXUnitTest;
using Labb3_Miniräknare;

namespace Labb3_MiniräknareXUnitTest
{
    public class CalculationsTest
    {
        //ADDITION
        [Theory]
        [InlineData(20, 20.5, 40.5, true)]
        [InlineData(10, -20, 30, true)]
        [InlineData(30.8, 5.5, 36.3, true)]
        [InlineData(5, -3, -2, false)]
        [InlineData(10, 3, 12, false)]
        public void Test_Addition(double num1, double num2, double result, bool isItTrue)
        {
            //Arrange
            var calc = new Calculations();

            //Act
            var isValid = calc.Addition(num1, num2);
            var actual = isValid == result;

            //Assert
            Assert.Equal(isItTrue, actual);
        }

        //SUBTRAKTION
        [Fact]
        public void Test_Subtraction_Positive_Result()
        {
            //Arrange
            var posNum = new Calculations();

            //Act
            var actual = posNum.Subtraction(4, 2);
            var expected = 2;

            //Assert
            Assert.Equal(actual, expected);
        }
        [Fact]
        public void Test_Subtraction_Negative_Result()
        {
            //Arrange
            var negNum = new Calculations();

            //Act
            var actual = negNum.Subtraction(-10, 5);
            var expected = -15;

            //Assert
            Assert.Equal(actual, expected);
        }


        //DIVISION

        [Fact]
        public void Test_Division_Positive_Result()
        {
            //Arrange
            var posNum = new Calculations();

            //Act
            var actual = posNum.Division(50, 2);
            var expected = 25;

            //Assert
            Assert.Equal(actual, expected);
        }
        [Fact]
        public void Test_Division_Negative_Result()
        {
            //Arrange
            var negNum = new Calculations();

            //Act
            var actual = negNum.Division(-20, 2);
            var expected = -10;

            //Assert
            Assert.Equal(actual, expected);
        }
        [Theory]
        [InlineData(5, 0, 5, false)]
        [InlineData(0, 5, 0, true)]
        [InlineData(5, 0.25, 20, true)]
        public void Test_Division_With_0(double num1, double num2, double result, bool isItTrue)
        {
            //Arrange
            var calc = new Calculations();

            //Act
            var isValid = calc.Division(num1, num2);
            var actual = isValid == result;

            //Assert
            Assert.Equal(isItTrue, actual);
        }


        //MULTIPLIKATION
        [Fact]
        public void Test_Multiplication_Positive_Result()
        {
            //Arrange
            var num = new Calculations();

            //Act
            var actual = num.Multiplication(3, 3);
            var expected = 9;

            //Assert
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void Test_Multiplication_Negative_Result()
        {
            //Arrange
            var negNum = new Calculations();

            //Act
            var actual = negNum.Multiplication(-3, 3);
            var expected = -9;

            //Assert
            Assert.Equal(actual, expected);
        }



        //LISTA
        [Theory]
        [InlineData("2 + 3 = 5", true)]
        [InlineData("1 x 3 = 3", true)]
        [InlineData("-2 - 3 = -5", true)]
        [InlineData("15 / 5 = 3", true)]
        [InlineData("16 + 5 = 21", false)]
        public void Test_ShowCalculations(string expected, bool isItTrue)
        {
            //Arrange
            var c = new Calculations();
            c.ListOfCalculations.Add("2 + 3 = 5");
            c.ListOfCalculations.Add("1 x 3 = 3");
            c.ListOfCalculations.Add("-2 - 3 = -5");
            c.ListOfCalculations.Add("15 / 5 = 3");

            //Act
            var isValid = c.ShowCalculations();
            var actual = isValid == expected;

            //Assert
            Assert.Equal(isItTrue, actual);
        }


    }
}
