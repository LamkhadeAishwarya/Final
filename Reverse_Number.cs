using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    internal class Reverse_Number
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());
            int rev = 0;
            int rem;
            while (num > 0)
            {
                rem = num % 10;
                rev = (rev * 10)+ rem;
                num = num / 10;
            }
            Console.WriteLine("Reverse Number Of Given Number is" +rev);
        }
    }
}
