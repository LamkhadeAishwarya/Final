using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    internal class UpperCase
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Character");
            char ch = Convert.ToChar(Console.ReadLine());
            if (ch >= 'A' && ch <= 'Z')
            {
                Console.WriteLine("Upper Character");
            }
            else if(ch>='a' && ch<='z')
            {
                Console.WriteLine( "Lower Character");
            }
        }
    }
}
