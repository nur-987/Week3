using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountWords
{
    /// <summary>
    /// create a function to input a string and 
    /// count number of words are present  in the string , 
    /// then  print them separately
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi. Please type a sentence.");
            string input = Console.ReadLine();
            Counter(input);

        }

        public static void Counter(string str)
        {
            string[] words = str.Split(' ');
            Console.WriteLine("The number of words in that sentence was: " + words.Length);
            Console.WriteLine("The words are: ");
            foreach(string word in words)
            {
                Console.WriteLine(word);
            }

            Console.ReadLine();
        }
    }

}
