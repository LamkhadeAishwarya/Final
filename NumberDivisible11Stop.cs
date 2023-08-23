using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    internal class NumberDivisible11Stop
    {
        static void Main(string[] args)
        {
            int i;
            for ( i = 1; i <= 25; i++)
            {
                Console.WriteLine(i);
                if (i % 11 == 0)
                {
                    break;
                }
            }
           
        }
    }
}
