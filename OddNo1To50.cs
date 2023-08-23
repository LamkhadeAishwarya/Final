using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    internal class OddNo1To50
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine( "Odd Number "+i);
                }
            }
        }
    }
}
