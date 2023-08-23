using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    internal class Positive_Number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num >= 0)
            {
                Console.WriteLine("Positive Number");
            }
            else if(num<=0)
            {
                Console.WriteLine("Negative Number");
            }

        }
    }
}
