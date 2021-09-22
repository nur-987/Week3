using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    static class Operation
    {
        public static void performOperations(int a, int b, myDelegate myDel)
        {
            myDel(a, b);
        }
    }
    class Addition
    {
        public void Add(int a, int b)
        {
            Console.WriteLine("Answer in Add method: " + (a + b));
        }
    }
    class Subtract
    {
        public void Sub(int a, int b)
        {
            Console.WriteLine("Answer in Sub method: " + (a - b));
        }

    }
}
