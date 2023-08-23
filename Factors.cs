using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Final
{
    internal class Factors
    {

       
        static void Main(string[] args)
        {
            int num = 5;
        
            int count = 0;
            int sum = 0;

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    sum = sum + i;
                    
                    count++;
                }
            }
            double avg=sum/count;
            Console.WriteLine(avg);
        }
    }
}
