using Xunit;
using CalculatorTooZirCorp;

namespace MyxUnitTests
{
    public class CalculatorTest
    {
        private readonly Calculator calculator;

        public CalculatorTest()
        {
            calculator = new Calculator();
        }

        ////ЦЕЛЫЕ ЧИСЛА

        //СУММА 
        [Fact]
        public void Add_TwoPositiveNums()
        {
            int a = 12;
            int b = 26;
            double result = calculator.Add(a, b);
            Assert.Equal(a + b, result);
        }

        [Fact]
        public void Add_TwoNegativeNums()
        {
            int a = -45;
            int b = -21;
            double result = calculator.Add(a, b);
            Assert.Equal(a + b, result);
        }

        [Fact]
        public void Add_OnePosOneNegNums()
        {
            int a = 12;
            int b = -31;
            double result = calculator.Add(a, b);
            Assert.Equal(a + b, result);
        }

        [Fact]
        public void Add_WithZero()
        {
            int a = 0;
            int b = 5;
            double result = calculator.Add(a, b);
            Assert.Equal(a + b, result);
        }

        //ÐÀÇÍÎÑÒÜ

        [Fact]
        public void Subtract_TwoPositiveNums()
        {
            int a = 15;
            int b = 7;
            double result = calculator.Substract(a, b);
            Assert.Equal(a - b, result);
        }

        [Fact]
        public void Subtract_TwoNegativeNums()
        {
            int a = -15;
            int b = -7;
            double result = calculator.Substract(a, b);
            Assert.Equal(a - b, result);
        }

        [Fact]
        public void Subtract_OnePosOneNegNums()
        {
            int a = 15;
            int b = -7;
            double result = calculator.Substract(a, b);
            Assert.Equal(a - b, result);
        }

        [Fact]
        public void Subtract_WithZero()
        {
            int a = 15;
            int b = 0;
            double result = calculator.Substract(a, b);
            Assert.Equal(a - b, result);
        }

        //ÏÐÎÈÇÂÅÄÅÍÈÅ
        [Fact]
        public void Multiply_TwoPositiveNums()
        {
            int a = 4;
            int b = 5;
            double result = calculator.Mulltiply(a, b);
            Assert.Equal(a * b, result);
        }

        [Fact]
        public void Multiply_TwoNegativeNums()
        {
            int a = -4;
            int b = -5;
            double result = calculator.Mulltiply(a, b);
            Assert.Equal(a * b, result);
        }

        [Fact]
        public void Multiply_OnePosOneNegNums()
        {
            int a = 4;
            int b = -5;
            double result = calculator.Mulltiply(a, b);
            Assert.Equal(a * b, result);
        }

        [Fact]
        public void Multiply_WithZero()
        {
            int a = 4;
            int b = 0;
            double result = calculator.Mulltiply(a, b);
            Assert.Equal(a * b, result);
        }

        //×ÀÑÒÍÎÅ
        [Fact]
        public void Divide_TwoPositiveNums()
        {
            int a = 15;
            int b = 3;
            double result = a / b;
            Assert.Equal(a / (double)b, result);
        }

        [Fact]
        public void Divide_TwoNegativeNums()
        {
            int a = -15;
            int b = -3;
            double result = a / b;
            Assert.Equal(a / (double)b, result);
        }

        [Fact]
        public void Divide_OnePosOneNegNums()
        {
            int a = 15;
            int b = -3;
            double result = a / b;
            Assert.Equal(a / (double)b, result);
        }

        [Fact]
        public void Divide_ByZero()
        {
            int a = 15;
            double b = 0.0;
            double result = a / b;
            Assert.Equal(double.PositiveInfinity, result);
        }

        //ÄÎÐÎÁÍÛÅ ×ÈÑËÀ

        //ÑÓÌÌÀ

        [Fact]
        public void Add_TwoPositiveNumsF()
        {
            double a = 12.5;
            double b = 26.7;
            double result = calculator.Add(a, b);
            Assert.Equal(a + b, result);
        }

        [Fact]
        public void Add_TwoNegativeNumsF()
        {
            double a = -45.2;
            double b = -21.8;
            double result = calculator.Add(a, b);
            Assert.Equal(a + b, result);
        }

        [Fact]
        public void Add_OnePosOneNegNumsF()
        {
            double a = 12.5;
            double b = -31.7;
            double result = calculator.Add(a, b);
            Assert.Equal(a + b, result);
        }

        [Fact]
        public void Add_WithZeroF()
        {
            double a = 0.0;
            double b = 5.5;
            double result = calculator.Add(a, b);
            Assert.Equal(a + b, result);
        }

        //ÐÀÇÍÎÑÒÜ

        [Fact]
        public void Subtract_TwoPositiveNumsF()
        {
            double a = 15.5;
            double b = 7.2;
            double result = calculator.Substract(a, b);
            Assert.Equal(a - b, result);
        }

        [Fact]
        public void Subtract_TwoNegativeNumsF()
        {
            double a = -15.5;
            double b = -7.2;
            double result = calculator.Substract(a, b);
            Assert.Equal(a - b, result);
        }

        [Fact]
        public void Subtract_OnePosOneNegNumsF()
        {
            double a = 15.5;
            double b = -7.2;
            double result = calculator.Substract(a, b);
            Assert.Equal(a - b, result);
        }

        [Fact]
        public void Subtract_WithZeroF()
        {
            double a = 15.5;
            double b = 0.0;
            double result = calculator.Substract(a, b);
            Assert.Equal(a - b, result);
        }

        //ÏÐÎÈÇÂÅÄÅÍÈÅ

        [Fact]
        public void Multiply_TwoPositiveNumsF()
        {
            double a = 4.5;
            double b = 5.2;
            double result = calculator.Mulltiply(a, b);
            Assert.Equal(a * b, result);
        }

        [Fact]
        public void Multiply_TwoNegativeNumsF()
        {
            double a = -4.5;
            double b = -5.2;
            double result = calculator.Mulltiply(a, b);
            Assert.Equal(a * b, result);
        }

        [Fact]
        public void Multiply_OnePosOneNegNumsF()
        {
            double a = 4.5;
            double b = -5.2;
            double result = calculator.Mulltiply(a, b);
            Assert.Equal(a * b, result);
        }

        [Fact]
        public void Multiply_WithZeroF()
        {
            double a = 4.5;
            double b = 0.0;
            double result = calculator.Mulltiply(a, b);
            Assert.Equal(a * b, result);
        }

        //×ÀÑÒÍÎÅ

        [Fact]
        public void Divide_TwoPositiveNumsF()
        {
            double a = 15.5;
            double b = 3.1;
            double result = a / b;
            Assert.Equal(a / b, result);
        }

        [Fact]
        public void Divide_TwoNegativeNumsF()
        {
            double a = -15.5;
            double b = -3.1;
            double result = a / b;
            Assert.Equal(a / b, result);
        }

        [Fact]
        public void Divide_OnePosOneNegNumsF()
        {
            double a = 15.5;
            double b = -3.1;
            double result = a / b;
            Assert.Equal(a / b, result);
        }

        [Fact]
        public void Divide_ByZeroF()
        {
            double a = 15.5;
            double b = 0.0;
            double result = a / b;
            Assert.Equal(double.PositiveInfinity, result);
        }

        //ÖÅËÛÅ È ÄÐÎÁÍÛÅ ×ÈÑËÀ

        //ÑÓÌÌÀ

        [Fact]
        public void Add_TwoPositiveNumsM()
        {
            double a = 12;
            double b = 26.5;
            double result = calculator.Add(a, b);
            Assert.Equal(a + b, result);
        }

        [Fact]
        public void Add_TwoNegativeNumsM()
        {
            double a = -45;
            double b = -21.5;
            double result = calculator.Add(a, b);
            Assert.Equal(a + b, result);
        }

        [Fact]
        public void Add_OnePosOneNegNumsM()
        {
            double a = 12;
            double b = -31.5;
            double result = calculator.Add(a, b);
            Assert.Equal(a + b, result);
        }

        [Fact]
        public void Add_WithZeroM()
        {
            double a = 0;
            double b = 5.5;
            double result = calculator.Add(a, b);
            Assert.Equal(a + b, result);
        }

        //ÐÀÇÍÎÑÒÜ

        [Fact]
        public void Subtract_TwoPositiveNumsM()
        {
            double a = 15;
            double b = 7.5;
            double result = calculator.Substract(a, b);
            Assert.Equal(a - b, result);
        }

        [Fact]
        public void Subtract_TwoNegativeNumsM()
        {
            double a = -15;
            double b = -7.5;
            double result = calculator.Substract(a, b);
            Assert.Equal(a - b, result);
        }

        [Fact]
        public void Subtract_OnePosOneNegNumsM()
        {
            double a = 15;
            double b = -7.5;
            double result = calculator.Substract(a, b);
            Assert.Equal(a - b, result);
        }

        [Fact]
        public void Subtract_WithZeroM()
        {
            double a = 15;
            double b = 0.0;
            double result = calculator.Substract(a, b);
            Assert.Equal(a - b, result);
        }

        //ÏÐÎÈÇÂÅÄÅÍÈÅ

        [Fact]
        public void Multiply_TwoPositiveNumsM()
        {
            double a = 4;
            double b = 5.5;
            double result = calculator.Mulltiply(a, b);
            Assert.Equal(a * b, result);
        }

        [Fact]
        public void Multiply_TwoNegativeNumsM()
        {
            double a = -4;
            double b = -5.5;
            double result = calculator.Mulltiply(a, b);
            Assert.Equal(a * b, result);
        }

        [Fact]
        public void Multiply_OnePosOneNegNumsM()
        {
            double a = 4;
            double b = -5.5;
            double result = calculator.Mulltiply(a, b);
            Assert.Equal(a * b, result);
        }
            
        [Fact]
        public void Multiply_WithZeroM()
        {
            double a = 4;
            double b = 0.0;
            double result = calculator.Mulltiply(a, b);
            Assert.Equal(a * b, result);
        }

        //×ÀÑÒÍÎÅ
        [Fact]
        public void Divide_TwoPositiveNumsM()
        {
            double a = 15;
            double b = 3.5;
            double result = a / b;
            Assert. Equal(a / b, result);
        }

        [Fact]
        public void Divide_TwoNegativeNumsM()
        {
            double a = -15;
            double b = -3.5;
            double result = a / b;
            Assert.Equal(a / b, result);
        }

        [Fact]
        public void Divide_OnePosOneNegNumsM()
        {
            double a = 15;
            double b = -3.5;
            double result = a / b;
            Assert.Equal(a / b, result);
        }

        [Fact]
        public void Divide_ByZeroM()
        {
            double a = 15;
            double b = 0.0;

            double result = a / b;
            Assert.Equal(double.PositiveInfinity, result);
        }
    }
}
