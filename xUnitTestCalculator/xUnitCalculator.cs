using CalculatorTooZirCorp;
using Xunit;

namespace xUnitTestCalculator
{
    public class xUnitCalculator
    {
        private Calculator calculator;

        public void Setup()
        {   
            calculator = new Calculator();
        }
        //—”ÃÃ¿

        [Fact]
        public void Add_TwoPositiveNums()
        {
            double a = 12;
            double b = 26;

            double result = calculator.Add(a, b);
            Assert.Equal(a + b, a + b);
        }
        [Fact]
        public void Add_TwoNegativsNums()
        {
            double a = -45;
            double b = -21;

            double result = calculator.Add(a, b);
            Assert.Equal(a + b, result);
        }
        [Fact]
        public void Add_OnePosOneNegNums()
        {
            double a = 12;
            double b = -31;

            double result = calculator.Add(a, b);
            Assert.Equal(a + b, result);
        }
        [Fact]
        public void Add_OneNegOnePosNums()
        {
            double a = -12.89;
            double b = 31;

            double result = calculator.Add(a, b);
            Assert.Equal(a + b, result);
        }

        [Fact]
        public void Add_OneZeroOnePosNums()
        {
            double a = 0;
            double b = 5.21;

            double result = calculator.Add(a, b);
            Assert.Equal(a + b, result);
        }

        [Fact]
        public void Add_OnePosOneZeroNums()
        {
            double a = 8.9;
            double b = 0;

            double result = calculator.Add(a, b);
            Assert.Equal(a + b, result);
        }

        [Fact]
        public void Add_OneZeroOneNegNums()
        {
            double a = 0;
            double b = -6.122;

            double result = calculator.Add(a, b);
            Assert.Equal(a + b, result);
        }

        [Fact]
        public void Add_OneNegOneZeroNums()
        {
            double a = -64;
            double b = 0;

            double result = calculator.Add(a, b);
            Assert.Equal(a + b, result);
        }


        //–¿«ÕŒ—“‹

        [Fact]
        public void Substract_TwoPosNums()
        {
            double a = 4.92;
            double b = 6.123;

            double result = calculator.Substract(a, b);
            Assert.Equal(a - b, result);
        }

        [Fact]
        public void Substract_TwoNegsNums()
        {
            double a = -4.92;
            double b = -6.123;

            double result = calculator.Substract(a, b);
            Assert.Equal(a - b, result);
        }


        [Fact]
        public void Substract_OnePosOneNegNums()
        {
            double a = 44.32;
            double b = -10.3;

            double result = calculator.Substract(a, b);
            Assert.Equal(a - b, result);
        }


        [Fact]
        public void Substract_OneNegOnePosNums()
        {
            double a = -442;
            double b = 13.82;

            double result = calculator.Substract(a, b);
            Assert.Equal(a - b, result);
        }


        [Fact]
        public void Substract_OnePosOneZeroNums()
        {
            double a = 42.8991;
            double b = 0;

            double result = calculator.Substract(a, b);
            Assert.Equal(a - b, result);
        }

        [Fact]
        public void Substract_OneZeroOnePosNums()
        {
            double a = 0;
            double b = 1.123;

            double result = calculator.Substract(a, b);
            Assert.Equal(a - b, result);
        }



        //œ–Œ»«¬≈ƒ≈Õ»≈

        [Fact]
        public void Mul_TwoPosNums()
        {
            double a = 12.91;
            double b = 23;

            double result = calculator.Mulltiply(a, b);
            Assert.Equal(a * b, result);
        }

        [Fact]
        public void Mul_TwoNegsNums()
        {
            double a = -2.1;
            double b = -9.3;

            double result = calculator.Mulltiply(a, b);
            Assert.Equal(a * b, result);
        }


        [Fact]
        public void Mul_OnePosOneNegNums()
        {
            double a = 29;
            double b = -2;

            double result = calculator.Mulltiply(a, b);
            Assert.Equal(a * b, result);
        }


        [Fact]
        public void Mul_OneNegOnePosNums()
        {
            double a = -29;
            double b = 17;

            double result = calculator.Mulltiply(a, b);
            Assert.Equal(a * b, result);
        }


        [Fact]
        public void Mul_OneZeroNums()
        {
            double a = 0;
            double b = 27;

            double result = calculator.Mulltiply(a, b);
            Assert.Equal(a * b, result);
        }

        //◊¿—“ÕŒ≈
        [Fact]
        public void Div_TwoPosNums()
        {
            double a = 17;
            double b = 2;

            double result = calculator.Divide(a, b);
            Assert.Equal(a / b, result);
        }

        [Fact]
        public void Div_TwoNegsNums()
        {
            double a = -89;
            double b = -9;

            double result = calculator.Divide(a, b);
            Assert.Equal(a / b, result);
        }

        [Fact]
        public void Div_OnePosOneNegNums()
        {
            double a = 9;
            double b = -9;

            double result = calculator.Divide(a, b);
            Assert.Equal(a / b, result);
        }


        [Fact]
        public void Div_OneNegOnePosNums()
        {
            double a = -319.8;
            double b = 9;

            double result = calculator.Divide(a, b);
            Assert.Equal(a / b, result);
        }

        
    }
}