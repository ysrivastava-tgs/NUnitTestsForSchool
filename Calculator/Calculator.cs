using NUnitTests;
using System;

namespace CCalculator
{
    public class Calculator
    {
        private readonly Offset offset;
        public Calculator(Offset _offset)
        {
            offset = _offset;
        }
        public int Add(int num1,int num2) 
        {
            return num1 + num2;
        }
        public int AddWithOffset(int num1, int num2)
        {
            return num1 + num2 + offset.Get();
        }
        public string ConcatWithOffset(string s)
        {
            return s+offset.Concatinating();
        }
        public int Sub(int num1, int num2)
        {
            return num1 - num2;
        }
        public int Mul(int num1, int num2)
        {
            return num1 * num2;
        }
        public int Div(int num1,int num2)
        {
            return num1 / num2;
        }
    }
}
