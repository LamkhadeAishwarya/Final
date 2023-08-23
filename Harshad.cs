using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
  internal class Harshad
    {
        static void Main(string[] args)
        {
            int num = 21;
            int rem = 0;
            int temp = num;
            int sum = 0;
            while (num > 0)
            {
                rem = num % 10;
                sum=sum + rem;
                num = num / 10;
            }
            if (temp%sum==0)
            {
                Console.WriteLine("Harshad Number");
            }
            else {
                Console.WriteLine( "Not");
            }


        }
    }
}
