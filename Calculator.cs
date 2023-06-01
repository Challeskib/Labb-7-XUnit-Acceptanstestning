using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_7___XUnit___Acceptanstestning
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            Console.WriteLine($"Sum = {a+b}");
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            Console.WriteLine($"Difference = {a-b}");
            return a - b;
        }

        public int Divide(int a, int b)
        {
            Console.WriteLine($"Quotient = {a/b}");

            return a / b;
        }

        public int Multiply(int a, int b)
        {
            Console.WriteLine($"Product = {a * b}");
            return a * b;
        }


    }
}
