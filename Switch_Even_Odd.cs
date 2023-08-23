using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    internal class Switch_Even_Odd
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Enter Number Which have To be check Its Even Or Odd Number");
            int number = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Choice");
            //int ch = Convert.ToInt32(Console.ReadLine());
            switch (number % 2)
            {
                case 0 :
                    {
                        Console.WriteLine("Even Number");
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine( "Odd Number");
                        break;
                    }
                default:
                    {
                        Console.WriteLine( "Enter Valid Number");
                        break;
                    }

            }
        }
    }
}
