using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final

    internal class CountNumberOfDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            while (num > 0)
            {
                int rem = num % 10;
                count++;
                num = num / 10;
            }
            Console.WriteLine("Count Of Digit:"+count);
        }
    }
}
