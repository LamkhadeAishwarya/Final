using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    internal class Armstrong_Number
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Enter Number Which have to be check it is Armstrong or Not");
            int num = Convert.ToInt32(Console.ReadLine());
            int rem;
            int sum = 0;
            int cube = 0;
            int temp = num;
            while (num != 0)
            {
                rem = num % 10;
                cube = rem * rem * rem;
                sum = sum + cube;
                num = num / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine("Armstrong ");
            }
            else 
            {
                Console.WriteLine( "Not Armstrong");
            }
        }
    }
}
