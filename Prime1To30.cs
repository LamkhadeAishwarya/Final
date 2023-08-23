using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    internal class Prime1To30
    {
        static void Main(string[] args)
        {

          
            for (int i = 1; i <= 30; i++)
            {
                bool isprime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isprime = false;
                        break;
                    }
                }

                if (isprime)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
