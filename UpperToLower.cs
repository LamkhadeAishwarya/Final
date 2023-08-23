using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    internal class UpperToLower
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Enter Character");
            char ch = Convert.ToChar(Console.ReadLine());
            if (ch >= 'A' && ch <= 'Z')
            {
                ch = (char)(ch + 32);
                Console.WriteLine(ch);
            }
            else
            {
                if (ch >= 'a' && ch <= 'z')
                {
                    ch = (char)(ch - 32);
                    Console.WriteLine(ch);
                }
            }
        }
    }
}
