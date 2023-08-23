using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
   internal class SumofOddDigitNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());
            int rem;
            int sum = 0;
            while (num > 0)
            {
                rem = num % 10;
                if (rem % 2 != 0)
                {
                    sum = sum + rem;
                }
                num = num / 10;
            }
            Console.WriteLine(sum);
        }
    }
}
