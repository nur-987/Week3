using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorWithInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculatorcs myInterface = new MyCalculator();

            Console.WriteLine("Please input 2 numbers to do all operation on");
            Console.WriteLine("FirstNumber: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Second Number: ");
            int b = Int32.Parse(Console.ReadLine());

            myInterface.Add(a, b);
            myInterface.Sub(a, b);
            myInterface.Mult(a, b);
            myInterface.Div(a, b);

            Console.ReadLine();
        }
    }
}
