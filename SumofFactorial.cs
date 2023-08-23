using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    internal class SumofFactorial
    {
        static void Main(string[] args)
        {
            int fact = 1;
            int sum = 0;
            for (int i = 1; i <= 4; i++)
            {
                fact = fact * i;
                sum=sum+ fact;
            }
            Console.WriteLine(sum);
        }
    }
}
