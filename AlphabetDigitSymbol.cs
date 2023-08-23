using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    internal class AlphabetDigitSymbol
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Character");
            char ch = Convert.ToChar(Console.ReadLine());
            if (ch >= '0' && ch <= '9')
            {
                Console.WriteLine("Digit");
            }
            else if (ch >= 'a' && ch <= 'z')
            {
                Console.WriteLine("Alphabet");
            }
            else {
                Console.WriteLine("Symbol");
            }
        }
    }
}
