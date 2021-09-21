using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    /// <summary>
    /// find a prime number between 1 to 100 , 
    /// then reverse the number 
    /// if the reverse number is also a prime one , 
    /// then store the number
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets check for prime number from 1 to 100");
            for(int i = 1; i <= 100; i++)
            {
                Checker(i);
            }
        }

        public static void Checker(int num)
        {
            int i;
            List<int> pmNumber = new List<int>();

            for(i = 2; i<= num -1; i++)
            {
                if(num % i == 0)
                {
                    //not a PM
                    Console.WriteLine("searching...");
                }
            }
            if(i == num)
            {
                pmNumber.Add(num);
            }
            //not a PM
            Console.WriteLine("searching...");

            Console.WriteLine(pmNumber);
        }
    }
}
