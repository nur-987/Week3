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
                Console.WriteLine("Enter the first angel");
                int num1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter the 2 angel");
                int num2 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter the 3 angel");
                int num3 = Int32.Parse(Console.ReadLine());

                int total = num1 + num2 + num3;
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
                Console.WriteLine("Enter the first angel");
                int num1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter the 2 angel");
                int num2 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter the 3 angel");
                int num3 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter the 4 angel");
                int num4 = Int32.Parse(Console.ReadLine());

                int total = num1 + num2 + num3 + num4;
                if (total == 360)
                {
                    Console.WriteLine("The 4 angels make a shape");
                }
                else
                {
                    Console.WriteLine("The 4 angels do not make a shape");
                }
                Console.ReadLine();
                //rectangle, square, trapezium
                //360 total
            }
            if(res == 5)
            {
                Console.WriteLine("Enter the first angel");
                int num1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter the 2 angel");
                int num2 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter the 3 angel");
                int num3 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter the 4 angel");
                int num4 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter the 4 angel");
                int num5 = Int32.Parse(Console.ReadLine());

                int total = num1 + num2 + num3 + num4 + num5;
                if(total == 540)
                {
                    Console.WriteLine("The 5 angels make a shape");
                }
                else
                {
                    Console.WriteLine("The 5 angels do not make a shape");
                }
                //polygon
                // (res-2)*180
            }

        }

    }
}
