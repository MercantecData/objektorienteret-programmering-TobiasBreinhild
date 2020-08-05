using System;

namespace Maths
{
    public class MathClass
    {
        // Plus Functions
        public int Plus(int a, int b)
        {
            return a + b;
        }
        public float Plus(float a, float b)
        {
            return a + b;
        }
        public string Plus(string a, string b)
        {
            int result = Int32.Parse(a + b);
            string plusSolution = result.ToString();
            return plusSolution;
        }

        // Minus Functions
        public int Minus(int a, int b)
        {
            return a - b;
        }
        public float Minus(float a, float b)
        {
            return a - b;
        }
        public string Minus(string a, string b)
        {
            int result = Int32.Parse(a + b);
            string MinusSolution = result.ToString();
            return MinusSolution;
        }
        /*
        // Multiply Functions
        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public float Multiply(float a, float b)
        {
            return a * b;
        }
        public string Multiply(string a, string b)
        {
            return a * b;
        }

        // Divide Function
        public int Divide(int a, int b)
        {
            return a / b;
        }
        public float Divide(float a, float b)
        {
            return a / b;
        }
        public string Divide(string a, string b)
        {
            return a / b;
        }
        */
    }
}
