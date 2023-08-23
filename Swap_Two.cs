using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    internal class Swap_Two
    {
        static void Main(string[] args)
        {
            int temp = 0;
            int a = 2;
            int b = 3;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After Swapping Value Of A is" + a);
            Console.WriteLine("After Swapping Value Of B is" + b);
        }
    }
}
