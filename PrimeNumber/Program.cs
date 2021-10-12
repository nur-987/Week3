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
        public static List<int> reverseNum = new List<int>();
        public static List<int> pmNumber = new List<int>();
        static void Main(string[] args)
        {
            Console.WriteLine("Lets check for prime number from 1 to 100");
            for(int i = 1; i <= 100; i++)
            {
                CheckifPrime(i);
            }

            Display();
        }

        public static void CheckifPrime(int num) //CheckIfPrime
        {
            int i;

            for (i = 2; i<= num -1; i++)
            {
                if(num % i == 0)
                {
                    //not a PM
                    return;
                }
            }
            if(i == num)
            {
                //is a PM 
                int x = num;
                Reverse(x);
                Console.WriteLine("This is a PM number:" + x);

            }
            return;

        }

        public static void Reverse(int num)
        {
            int reverse = 0;
            if (num >=10)
            {
                int remainder = num % 10;
                reverse = (reverse * 10) + remainder;
                num = num / 10;
            }

            reverseNum.Add(reverse);

            foreach (int revNum in reverseNum)
            {
                int i;
                for (i = 2; i <= revNum - 1; i++)
                {
                    if (num % i == 0)
                    {
                        //not a PM
                        return;
                    }
                }
                if (i == num)
                {
                    //is a PM 
                    int x = num;
                    Console.WriteLine("This is a PM number:" + x);
                    pmNumber.Add(x);

                }
                return;
            }

        }

        public static void Display()
        {
            foreach (int x in pmNumber)
            {
                Console.WriteLine(x);
            }
        }


    }
}


