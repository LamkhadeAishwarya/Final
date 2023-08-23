using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    
    
        internal class Single_Digit
        {
            static void Main(string[] args)
            {
                int count = 0;
                Console.WriteLine("Enter Number");
                int num = Convert.ToInt32(Console.ReadLine());
                int rem;
                while (num != 0)
                {
                    rem = num % 10;
                    count++;
                    num = num / 10;
                }
                if (count == 1)
                {
                    Console.WriteLine("Its a Single Digit ");
                }
                else if (count == 2)
                {
                    Console.WriteLine("Double Digit");
                }
                else
                {
                    Console.WriteLine("More Than Two Digit");
                }


            }
        }
    }

