using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
   internal class Swap_Without
    {
        static void Main(string[] args)
        {
            int x = 2;
            int y = 3;
            x = x + y;
            y = x - y;
            x = x - y;
            Console.WriteLine("After Swapping Value of X is " + x);
            Console.WriteLine("After swapping value of y is" + y);
        }
    }
}