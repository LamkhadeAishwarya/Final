using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    internal class LargestNumber_Three
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Enter Number First");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine( "Enter Second Number");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Third Number");
            int Third= Convert.ToInt32(Console.ReadLine());
            if (first > second && first > Third)
            {
                Console.WriteLine("First is Greater" + first);
            }
            else if (second > first && second > Third)
            {
                Console.WriteLine("Second is Greater Number"+second);
            }
            else {
                Console.WriteLine("Third Number is Grteater" + Third);
            }
        }
    }
}
