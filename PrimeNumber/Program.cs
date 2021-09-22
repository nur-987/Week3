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
            //List<int> pmNumber = new List<int>();

            for (i = 2; i<= num -1; i++)
            {
                if(num % i == 0)
                {
                    //not a PM
                    //Console.WriteLine("searching...");
                    return;
                }
            }
            if(i == num)
            {
                //is a PM 
                int x = num;
                Reverse(x);
                Console.WriteLine("This is a PM number:" + num);

            }
            return;

        }

        public static void Reverse(int num)
        {
            List<int> pmNumber = new List<int>();
            pmNumber.Add(num);
        }
    }
}

/*Currently cannot store the PM number 
 * and reverse it to do a 2nd check
 */
