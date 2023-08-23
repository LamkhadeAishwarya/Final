using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    internal class BreakStatementForLoop
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
                if (i == 5)
                {
                    break;
                }
            }
            
        }
    }
}
