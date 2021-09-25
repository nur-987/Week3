using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angels
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many angels do you want to enter?");
            int res = Int32.Parse(Console.ReadLine());
            if(res == 3)
            {
                GetAngles(out string[] angel);
                int total = Int32.Parse(angel[0]) + Int32.Parse(angel[1]) + Int32.Parse(angel[2]);

                if(total == 180)
                {
                    Console.WriteLine("The 3 angels make a triangle");
                }
                else
                {
                    Console.WriteLine("The 3 angels do not make a triangle");
                }
                Console.ReadLine();

            }
            if(res == 4)
            {
                GetAngles(out string[] angel);
                int total = Int32.Parse(angel[0]) + Int32.Parse(angel[1]) + Int32.Parse(angel[2]) + Int32.Parse(angel[3]);

                if (total == 360)
                {
                    Console.WriteLine("The 4 angels make a 4 sided shape");
                }
                else
                {
                    Console.WriteLine("The 4 angels do not make a shape");
                }
                Console.ReadLine();

            }
            if(res == 5)
            {
                GetAngles(out string[] angel);
                int total = Int32.Parse(angel[0]) + Int32.Parse(angel[1]) + Int32.Parse(angel[2]) + 
                            Int32.Parse(angel[3]) + Int32.Parse(angel[4]);

                if (total == 540)
                {
                    Console.WriteLine("The 5 angels make a polygon");
                }
                else
                {
                    Console.WriteLine("The 5 angels do not make a shape");
                }

            }

        }

        static void GetAngles(out string[] angels)
        {
            Console.WriteLine("Please input your angels to check.");
            Console.WriteLine("Separate them with a comma");
            string input = Console.ReadLine();
            string[] separatedAngel = input.Split(',');
            angels = separatedAngel;
            
        }

    }
}
