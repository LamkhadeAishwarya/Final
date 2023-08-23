using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    internal class EvenDigitFromNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());
            int rem;
            while (num > 0)
            {
                rem = num % 10;
                if (rem % 2 == 0)
                {
                    Console.WriteLine( rem);
                }
                num = num / 10;
            }
        }
    }
}
