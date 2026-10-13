using System;

namespace Subjects
{
    public class Math
    {
        public double sum(int num1, int num2)
        {
            return num1 + num2;
        }
        public double mult(int num1, int num2)
        {
            return num1 * num2;
        }
        public double subtraction(int num1, int num2)
        {
            return num1 - num2;
        }
        public double division(int num1, int num2)
        {        
            return num1 / num2;
        }
        public double squareroot(int num)
        {
            return System.Math.Sqrt(num);
        }
        public double average(int num1, int num2)
        {
            return (num1 + num2) / 2.0;
        }
        public double modulus(int num1, int num2)
        {
            return num1 % num2;
        }
        public double power(int num1, int num2)
        {
            return System.Math.Pow(num1, num2);
        }
        public double absolute(int num)
        {
            return System.Math.Abs(num);
        }
        public double max(int num1, int num2)
        {
            return System.Math.Max(num1, num2);
        }
        public double min(int num1, int num2)
        {
            return System.Math.Min(num1, num2);
        }
    }
}
