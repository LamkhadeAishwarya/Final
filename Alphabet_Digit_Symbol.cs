using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    internal class Alphabet_Digit_Symbol
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Character");
            int ch = Convert.ToChar(Console.ReadLine());
            if (ch > '0' && ch < '9')
            {
                Console.WriteLine("It is Digit");
            }
            else if (ch >='a' && ch <= 'z')
            {
                Console.WriteLine("It is Alphabet");
            }
            else
            {
                Console.WriteLine( "It is Symbol");
            }
        }
    }
}
