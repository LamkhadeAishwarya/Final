using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    internal class SPY
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());
            int rem;
            int sum = 0;
            int cube=1;
          
            while (num > 0)
            {
                rem = num % 10;
                sum = sum + rem;
                cube = cube * rem;
                num = num / 10;
                
               

            }
            Console.WriteLine(sum);
            Console.WriteLine( cube);
            if (sum == cube)
            {
                Console.WriteLine("Is a spy number");
            }
            else
            {
                Console.WriteLine("Not spy"); 
                
            }
        }
    }
}
