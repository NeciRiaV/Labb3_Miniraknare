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
            var calc = new Calculations();

            var isValid = calc.Addition(num1, num2);
            var actual = isValid == result;

            Assert.Equal(isItTrue, actual);
        }

        //SUBTRAKTION


        //DIVISION


        //MULTIPLIKATION
    }
}
