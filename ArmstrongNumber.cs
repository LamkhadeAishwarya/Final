using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    internal class ArmstrongNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());
            int rem;
            int sum = 0;
            int cube;
            int temp = num;
            while (num > 0)
            {
                 rem = num % 10;
                cube = rem*rem*rem;
                sum = sum + cube;
                num = num / 10;
            }
            Console.WriteLine(sum);
            if (temp == sum)
            {
                Console.WriteLine("Number is Armstrong");
            }
            else {
                Console.WriteLine( "Not Armstrong");
            }
        }
    }
}
