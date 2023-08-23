using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    internal class Sum1to10
    {

        static void Main(string[] args)
        {
            int i = 1;
            int sum = 0;
            while (i <= 10)
            {
                Console.WriteLine( i);
                sum = sum + i;
                i++;
            }
           
            Console.WriteLine("Sum of first 10 num is:"+sum);
            
        }
        
    }
}
