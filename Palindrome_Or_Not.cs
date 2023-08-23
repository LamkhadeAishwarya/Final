using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    internal class Palindrome_Or_Not
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());
            int rem;
            int rev=0;
            int temp = num;
           
            while (num != 0)
            {
                rem = num % 10;
                rev = (rev*10)+ rem;
                num = num / 10;
            }
            Console.WriteLine(rev);
            if (rev == temp)
            {
                Console.WriteLine("Its a Palindrome Number");
            }
            else {
                Console.WriteLine( "Its not Palindrome Number");
            }



        }
    }
}
