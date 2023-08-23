using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    internal class SumOf1To10
    {
        static void Main(string[] args)
        {

            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
                 sum = sum + i;
            }
            Console.WriteLine("Sum Of 1 To 10"+sum);
        }
    }
}
