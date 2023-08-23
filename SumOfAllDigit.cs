using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    internal class SumOfAllDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            int rem;
            while (num != 0)
            {
                rem = num % 10;
                sum = sum + rem;
                num = num / 10;
            }
            Console.WriteLine( $"Sum of all digit in num=:{sum}");
        }
    }
}
