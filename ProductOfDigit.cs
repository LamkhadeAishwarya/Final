using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
   internal class ProductOfDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());
            int product = 1;
            while (num > 0)
            {
                int rem = num % 10;
                product = product * rem;
                num = num / 10;
            }
            Console.WriteLine("Product Of Digit is:"+product);
        }
    }
}
