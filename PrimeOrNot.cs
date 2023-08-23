using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    internal class PrimeOrNot
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            for (int i = 2; i <= num; i++)
            {
                if (num % 2 == 0)
                {   
                    a = 1;
                    Console.WriteLine( "Not Prime");
                    break;
                }
            }
            if (a==0)
            {
                Console.WriteLine("Number is Prime");
            }
           
        }
    }
}
