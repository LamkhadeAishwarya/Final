using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
   internal class Duck_Number
    {
        static void Main(string[] args)
        {
            int num = 101;
            int count = 0;
            int rem = 0;
            while (num > 0)
            {
                rem = num % 10;
             
                if (rem == 0)
                {
                    count++;
                }
                num = num / 10;
            }
            if (count == 1)
            {
                Console.WriteLine("Duck Number");
            }
            else {
                Console.WriteLine( "Not");
            }
        }
    }
}
