using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    internal class KrushnmurtiNumber
    {
        static void Main(string[] args)
        {
            int num = 145;
            int temp = num;
            int sum = 0;
            int rem = 0;
            while (num > 0)
            {
               
                 rem = num % 10;
                int fact = 1;
                for (int i = 1; i <= rem; i++)
                {
                    fact = fact * i;
                }
                sum=sum+ fact;
                num = num / 10;
             
           
            }
       
            if (temp== sum)
            {
                Console.WriteLine("Krushnmurti Number");
            }
            else {
                Console.WriteLine( "Not");
            }
        }
    }
}
