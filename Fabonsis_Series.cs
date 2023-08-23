using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    internal class Fabonsis_Series
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int c = 0;
           
            for (int i = 0; i <= 10; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
            }
 

        }
    }
}
