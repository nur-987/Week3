using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorWithInterface
{
    class MyCalculator : ICalculatorcs
    {
        public void Add(int a, int b)
        {
            int x = (a + b);
            Console.WriteLine("Add answer is: " + x);
        }

        public void Div(int a, int b)
        {
            int x = (a / b);
            Console.WriteLine("Divide answer is: " + x);
        }

        public void Mult(int a, int b)
        {
            int x = (a * b);
            Console.WriteLine("Multiply answer is: " + x);
        }

        public void Sub(int a, int b)
        {
            int x = (a - b);
            Console.WriteLine("Subtract answer is: " + x);
        }
    }
}
