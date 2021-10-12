using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input in password");
            string myPass = Console.ReadLine();
            Program myProg = new Program();
            myProg.Checker(myPass);

        }

        public void Checker(string myPass)
        {
            for (int i = 0; i < myPass.Length - 1; i++)
            {
                if (myPass[i] == myPass[i + 1])
                {
                    Console.WriteLine("Passsword Should not have same Consecutive charcters");
                    Console.ReadLine();
                    return;
                }

            }

            if(myPass.Length <6 || myPass.Length > 24)
            {
                Console.WriteLine("Invalid password length");
                return;
            }

            char[] specialChar = {'!', '@', '#','$','%', '^', '&', '*','(',')', '+', '=', '_', '-', '{', '}', '[', ']',
                                        ';', ':', '"','?', '<', '>', ',', '.' };
            if (!myPass.Contains(specialChar))
            {
                Console.WriteLine("Contains a special char");
            }

            //if (myPass.Length > 6)
            //{
            //    if (myPass.Length < 24)
            //    {
            //        char[] specialChar = {'!', '@', '#','$','%', '^', '&', '*','(',')', '+', '=', '_', '-', '{', '}', '[', ']',
            //                            ';', ':', '"','?', '<', '>', ',', '.' };
            //        foreach (char c in specialChar)
            //        {
            //            if (myPass.Contains(c))
            //            {
            //                if (myPass.Any(char.IsUpper))
            //                {
            //                    if (myPass.Any(char.IsLower))
            //                    {
            //                        if (myPass.Any(char.IsDigit))
            //                        {
            //                            Console.WriteLine("Checking.....");
            //                        }
            //                        else
            //                        {
            //                            Console.WriteLine("Password needs to have a digit");
            //                        }
            //                    }
            //                    else
            //                    {
            //                        Console.WriteLine("Password has to have lower casing");
            //                    }
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Password needs an Upper case");
            //                }
            //            }
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Password must have less than 24 characters");
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("Password has to be more than 6 characters");
            //}

            Console.WriteLine("PASS all checks!");
            Console.ReadLine();

        }
    }


}

/*Issues: Have not include coma in the special characters.
 *         This checks for 2repetions instead of 3
 */         
