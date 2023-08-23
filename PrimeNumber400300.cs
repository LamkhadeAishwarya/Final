using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    internal class PrimeNumber400300
    {
        static void Main(string[] args)
        {
            for (int i = 400; i >= 300; i--)
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
                    Console.WriteLine( i);
                }
                {
                    
                }
            }
        }
    }
}
