using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    internal class Ternary
    {
        static void Main(string[] args)
        {
            int a = 5;
            string result = (a % 2 == 0) ? "Even" : "Odd";
            Console.WriteLine(result);
        }

    }
}
