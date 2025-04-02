using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTooZirCorp
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }
        public double Substract(double a, double b)
        {
            return a - b;
        }
        public double Mulltiply(double a, double b)
        {
            return a * b;
        }
        public double Divide(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("деление на 0 НИЗЯ");
            return a / b;
        }
    }
}
