using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    delegate void myDelegate(int i, int j);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first number: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("enter second number: ");
            int b = Int32.Parse(Console.ReadLine());

            Addition myAdd = new Addition();
            Subtract mySubtract = new Subtract();

            myDelegate newDelegate1 = new myDelegate(myAdd.Add);
            myDelegate newDelegate2 = new myDelegate(mySubtract.Sub);

            Operation.performOperations(a, b, newDelegate1);
            Operation.performOperations(a, b, newDelegate2);

            #region Mulicasting 
            //myDelegate newDelegate1 = new myDelegate(myAdd.Add);
            //newDelegate1 += mySubtract.Sub;
            //Operation.performOperations(a, b, newDelegate1);
            // *** here newDelegate1 is 2 methods at the same time. Add and Sub***
            #endregion

            Console.ReadLine();
        }
    }
}
