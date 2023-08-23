using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
   internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Thire Number");
            int num3 = Convert.ToInt32(Console.ReadLine());
            int sum = num + num2 + num3;
            float avg = (float)(sum) / 3;
            Console.WriteLine(avg);
        }
    }
}
