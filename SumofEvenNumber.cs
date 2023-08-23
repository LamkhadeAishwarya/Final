using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    internal class SumofEvenNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Enter Number that u are required ");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine( i );
                    sum = sum +i;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
