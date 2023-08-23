using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Final
{
   internal class Digit_Avg
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Enter Number");
            int num=Convert.ToInt32(Console.ReadLine());
            int rem;
            int sum = 0;
            int temp = num;
            int count= 0;
            float avg = 0;
            while (num > 0)
            {
                rem = num % 10;
                sum = sum + rem;
                count++;
                num = num / 10;
                
            }
            avg = (float)sum / count;
            Console.WriteLine( avg);

        }
    }
}
