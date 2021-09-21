using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Occurence
{
    /// <summary>
    /// find out if  a given word is present in given line , 
    /// if yes then find out its occurrence
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a sentence.");
            string input = Console.ReadLine();
            Console.WriteLine("Checking if your sentence has the word 'you'.... ");
            Checker(input);

        }

        public static void Checker(string str)
        {
            int counter = 0;
            string[] word = str.Split(' ');
            foreach(string wrd in word)
            {
                if(wrd == "you")
                {
                    counter++;
                }
            }
            Console.WriteLine("the word 'you' was in your sentence " + counter + " times.");
            Console.ReadLine();
        }
    }
}
