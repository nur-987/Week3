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
                //triangle
                //180 total
            }
            if(res == 4)
            {
                //rectangle, square, trapezium
                //360 total
            }
            if(res >= 5)
            {
                //polygon
                // (res-2)*180
            }

        }

        public static void AskNum()
        {
            Console.WriteLine("Please enter the angels in this format: XX,XX,XX");
            string angles = Console.ReadLine();
            string[] eachAng = angles.Split(',');

            
        }
    }
}
