using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorWithInterface
{
    interface ICalculatorcs
    {
        void Add(int a, int b);
        void Sub(int a, int b);
        void Mult(int a, int b);
        void Div(int a, int b);
    }
}
