using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    internal class FrequenctOfDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num=Convert.ToInt32(Console.ReadLine());
            int temp = num;
            for (int i = 1; i <= 9; i++)
            {
                int count = 0;
                
                while (num > 0)
                {
                    int rem = num % 10;
                    if (rem == i)
                    {
                        count++;
                    }
                    num = num / 10;
                }
                num = temp;
                Console.WriteLine(i+"------"+count);
                

            }
                
            
        }
    }
}
